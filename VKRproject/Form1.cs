using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Model;


namespace VKRproject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double processingTime = 0;
            double radiusStep = 0;
            double depthStep = 0;
            double density = 0;
            double thermalCapacity = 0;
            double heatSources = 0;
            double startTemperature = 0;
            double endTemperature = 0;
            double timeStep = 0;
            double transcalency = 0;


            try
            {
                processingTime = Convert.ToDouble(ProcessingTimeTextBox.Text);
                radiusStep = Convert.ToDouble(RadiusStepTextBox.Text);
                depthStep = Convert.ToDouble(DepthStepTextBox.Text);
                density = Convert.ToDouble(DensityTextBox.Text);
                thermalCapacity = Convert.ToInt32(ThermalCapacityTextBox.Text);
                heatSources = Convert.ToDouble(HeatSourcesTextBox.Text);
                startTemperature = Convert.ToDouble(StartTemperatureTextBox.Text);
                endTemperature = Convert.ToDouble(EndTemperatureTextBox.Text);
                timeStep = Convert.ToDouble(TimeStepTextBox.Text);
                transcalency = Convert.ToInt32(TranscalencyTextBox.Text);
            }
            catch
            {
                MessageBox.Show("Значения введены некорректно. Поля должны содержать только цифры.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                var planeParameters = new PlaneParameters(processingTime,radiusStep,depthStep,density,thermalCapacity,
                    heatSources,startTemperature,endTemperature,timeStep,transcalency);
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }


}
