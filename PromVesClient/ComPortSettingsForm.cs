using PromVesClient.Models;
using PromVesClient.Service;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Text;
using System.Windows.Forms;


namespace PromVesClient
{
    public partial class ComPortSettingsForm : Form
    {
        private readonly ComPortService _comPortService;
       
        public ComPortSettingsForm(ComPortService comPortService)
        {
            InitializeComponent();

            _comPortService = comPortService;
           
        }

        private void ComPortSettingsForm_Load(object sender, EventArgs e)
        {
            FillComboBox();
            LoadSettings();
        }
        private void FillComboBox()
        {
            FillPorts();
            FillBaudRates();
            FillDataBits();
            FillParity();
            FillStopBits();
            FillHandshake();
        }

        // метод универсального заполнения
        private void FillComboBox<T>(ComboBox comboBox, IEnumerable<T> values)
        {
            comboBox.Items.Clear();
            comboBox.DropDownStyle = ComboBoxStyle.DropDownList;

            foreach (var value in values)
                comboBox.Items.Add(value);
        }
        //поиск портов и добавления их
        private void FillPorts()
        {
            FillComboBox(cbPortName, _comPortService.GetAvailablePorts());
        }
        //метод заполнения BaudRates
        private void FillBaudRates()
        {
            FillComboBox(cbBaudRate, new[]
            {
        300,
        600,
        1200,
        2400,
        4800,
        9600,
        19200,
        38400,
        57600,
        115200
    });
        }
        private void FillDataBits()
        {
            FillComboBox(cbDataBits, new[]
            {
        5,
        6,
        7,
        8
    });
        }
        // следующие методы значения подгружаются из .NET
        private void FillParity()
        {
            FillComboBox(cbParity, Enum.GetNames<Parity>());
        }
        private void FillStopBits()
        {
            FillComboBox(cbStopBits, Enum.GetNames<StopBits>());
        }
        private void FillHandshake()
        {
            FillComboBox(cbHandshake, Enum.GetNames<Handshake>());
        }
        // заполнение одного порта
        private void LoadSettings()
        {
            var result = _comPortService.Load();

            if (!result.Success)
            {
                MessageBox.Show(
                    result.Message,
                    "Ошибка",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);

                return;
            }

            var configuration = result.Data;

            LoadPortToControls(
                configuration.SerialPorts[0],
                cbPortName,
                cbBaudRate,
                cbDataBits,
                cbParity,
                cbStopBits,
                cbHandshake);
        }
        //заполнение атоматически всех портов
        private void LoadPortToControls(
    SerialPortSettings settings,
    ComboBox portBox,
    ComboBox baudRateBox,
    ComboBox dataBitsBox,
    ComboBox parityBox,
    ComboBox stopBitsBox,
    ComboBox handshakeBox)
        {
            if (string.IsNullOrWhiteSpace(settings.PortName))
            {
                portBox.SelectedItem = null;
            }
            else
            {
                portBox.SelectedItem = settings.PortName;
            }

            baudRateBox.SelectedItem = settings.BaudRate;

            dataBitsBox.SelectedItem = settings.DataBits;

            parityBox.SelectedItem = settings.Parity.ToString();

            stopBitsBox.SelectedItem = settings.StopBits.ToString();

            handshakeBox.SelectedItem = settings.Handshake.ToString();
        }
        // метод чтения одного порта
        private SerialPortSettings ReadPortFromControls(
    ComboBox portBox,
    ComboBox baudRateBox,
    ComboBox dataBitsBox,
    ComboBox parityBox,
    ComboBox stopBitsBox,
    ComboBox handshakeBox,
    int id)
        {
            return new SerialPortSettings
            {
                Id = id,
                PortName = portBox.Text,
                BaudRate = int.Parse(baudRateBox.Text),
                DataBits = int.Parse(dataBitsBox.Text),
                Parity = Enum.Parse<Parity>(parityBox.Text),
                StopBits = Enum.Parse<StopBits>(stopBitsBox.Text),
                Handshake = Enum.Parse<Handshake>(handshakeBox.Text)
            };
        }
        //теперь общий метод для сохранения
        private void SaveSettings()
        {
            var configuration = new SerialPortConfiguration();

            configuration.SerialPorts.Add(
                ReadPortFromControls(
                    cbPortName,
                    cbBaudRate,
                    cbDataBits,
                    cbParity,
                    cbStopBits,
                    cbHandshake,
                    1));

            var result = _comPortService.Save(configuration);

            if (!result.Success)
            {
                MessageBox.Show(
                    result.Message,
                    "Ошибка",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }
        
        // кнопка сохранения заданных настроек
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (cbPortName.SelectedItem == null ||
     cbBaudRate.SelectedItem == null ||
     cbDataBits.SelectedItem == null ||
     cbParity.SelectedItem == null ||
     cbStopBits.SelectedItem == null ||
     cbHandshake.SelectedItem == null)
            {
                MessageBox.Show(
                    "Заполните все параметры COM-порта.",
                    "Ошибка",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            SaveSettings();

            MessageBox.Show(
                "Настройки успешно сохранены.",
                "COM-порты",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }
        // кнопка востановления дефолтных настроек
        private void btnRestoreDefaults_Click(object sender, EventArgs e)
        {
            var dialogResult = MessageBox.Show(
                "Восстановить настройки по умолчанию?",
                "Подтверждение",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (dialogResult != DialogResult.Yes)
                return;

            var result = _comPortService.RestoreDefaults();

            if (!result.Success)
            {
                MessageBox.Show(
                    result.Message,
                    "Ошибка",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);

                return;
            }

            var configuration = result.Data;

            LoadPortToControls(
     configuration.SerialPorts[0],
     cbPortName,
     cbBaudRate,
     cbDataBits,
     cbParity,
     cbStopBits,
     cbHandshake);

            MessageBox.Show(
                "Настройки по умолчанию загружены. Для применения нажмите «Сохранить».",
                "COM-порты",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }
    }
}
