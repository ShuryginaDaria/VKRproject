using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class PlaneParameters
    {
          #region Constants

        /// <summary>
        ///     Максимальное значение времени обработки
        /// </summary>
        private const double MaxProcessingTime = 5000;

        /// <summary>
        ///     Минимальное значение времени обработки
        /// </summary>
        private const double MinProcessingTime = 0;

        /// <summary>
        ///     Максимальное значение шага по радиусу образца
        /// </summary>
        private const double MaxRadiusStep = 1000;

        /// <summary>
        ///     Минимальное значение шага по радиусу образца
        /// </summary>
        private const double MinRadiusStep = 100;

                /// <summary>
        ///     Максимальное значение шага по глубине образца
        /// </summary>
        private const double MaxDepthStep = 1000;

        /// <summary>
        ///     Минимальное значение шага по глубине образца
        /// </summary>
        private const double MinDepthStep = 100;

        /// <summary>
        ///     Максимальное значение плотности образца
        /// </summary>
        private const double MaxDensity = 5500;

        /// <summary>
        ///     Минимальное значение плотности образца
        /// </summary>
        private const double MinDensity = 4000;

                /// <summary>
        ///     Максимальное значение теплоемкости
        /// </summary>
        private const double MaxThermalCapacity = 1000;

        /// <summary>
        ///     Минимальное значение теплоемкости
        /// </summary>
        private const double MinThermalCapacity = 500;

        /// <summary>
        ///     Максимальное значение источников тепла
        /// </summary>
        private const double MaxHeatSources = 2500000;

        /// <summary>
        ///     Минимальное значение источников тепла
        /// </summary>
        private const double MinHeatSources = 0;

        /// <summary>
        ///     Максимальное значение начальной температуры образца
        /// </summary>
        private const double MaxStartTemperature = 2500000;

        /// <summary>
        ///     Минимальное значение начальной температуры образца
        /// </summary>
        private const double MinStartTemperature = 0;

        /// <summary>
        ///     Максимальное значение конечной температуры образца
        /// </summary>
        private const double MaxEndTemperature = 2500000;

        /// <summary>
        ///     Минимальное значение конечной температуры образца
        /// </summary>
        private const double MinEndTemperature = 0;

        /// <summary>
        ///     Максимальное значение шага по времени
        /// </summary>
        private const double MaxTimeStep = 1000;

        /// <summary>
        ///     Минимальное значение шага по времени
        /// </summary>
        private const double MinTimeStep = 100;

        /// <summary>
        ///     Максимальное значение теплопроводности
        /// </summary>
        private const double MaxTranscalency = 10;

        /// <summary>
        ///     Минимальное значение теплопроводности
        /// </summary>
        private const double MinTranscalency = 4;

        #endregion


        #region Private fields

        /// <summary>
        ///     Время обработки
        /// </summary>
        private double _processingTime;

        /// <summary>
        ///     Шаг по радиусу образца
        /// </summary>
        private double _radiusStep;

        /// <summary>
        ///     Шаг по глубине образца
        /// </summary>
        private double _depthStep;

        /// <summary>
        ///     Плотность образца
        /// </summary>
        private double _density;

        /// <summary>
        ///     Теплоемкость
        /// </summary>
        private double _thermalCapacity;

        /// <summary>
        ///     Источники тепла
        /// </summary>
        private double _heatSourses;

        /// <summary>
        ///     Начальная температура образца
        /// </summary>
        private double _startTemperature;

        /// <summary>
        ///     Конечная температура образца
        /// </summary>
        private double _endTemperature;

        /// <summary>
        ///     Шаг по времени
        /// </summary>
        private double _timeStep;

        /// <summary>
        ///     Теплопроводность
        /// </summary>
        private double _transcalency;

        #endregion

        #region Properties

        /// <summary>
        ///     Время обработки
        /// </summary>
        public double ProcessingTime
        {
            get => _processingTime;
            private set => _processingTime =
                SetCorrectValue(ParameterType.ProcessingTime, value, MaxProcessingTime, MinProcessingTime);
        }

        /// <summary>
        ///     Шаг по радиусу образца
        /// </summary>
        public double RadiusStep
        {
            get => _radiusStep;
            private set => _radiusStep =
                SetCorrectValue(ParameterType.RadiusStep, value, MaxRadiusStep, MinRadiusStep);
        }

        /// <summary>
        ///     Шаг по глубмне образца
        /// </summary>
        public double DepthStep
        {
            get => _depthStep;
            private set => _depthStep =
                SetCorrectValue(ParameterType.DepthStep, value, MaxDepthStep, MinDepthStep);
        }

        /// <summary>
        ///     Плотность образца
        /// </summary>
        public double Density
        {
            get => _density;
            private set => _density =
                SetCorrectValue(ParameterType.Density, value, MaxDensity, MinDensity);
        }

        /// <summary>
        ///     Теплоемкость
        /// </summary>
        public double ThermalCapacity
        {
            get => _thermalCapacity;
            private set => _thermalCapacity =
                SetCorrectValue(ParameterType.ThermalCapacity, value, MaxThermalCapacity, MinThermalCapacity);
        }

        /// <summary>
        ///     Источники тепла
        /// </summary>
        public double HeatSources
        {
            get => _heatSourses;
            private set => _heatSourses =
                SetCorrectValue(ParameterType.HeatSources, value, MaxHeatSources, MinHeatSources);
        }

        /// <summary>
        ///     Начальная температура образца
        /// </summary>
        public double StartTemperature
        {
            get => _startTemperature;
            private set => _startTemperature =
                SetCorrectValue(ParameterType.StartTemperature, value, MaxStartTemperature, MinStartTemperature);
        }

        /// <summary>
        ///     Конечная температура образца
        /// </summary>
        public double EndTemperature
        {
            get => _endTemperature;
            private set => _endTemperature =
                SetCorrectValue(ParameterType.EndTemperature, value, MaxEndTemperature, MinEndTemperature);
        }

        /// <summary>
        ///     ТШаг по времени
        /// </summary>
        public double TimeStep
        {
            get => _timeStep;
            private set => _timeStep =
                SetCorrectValue(ParameterType.TimeStep, value, MaxTimeStep, MinTimeStep);
        }

        /// <summary>
        ///     Теплопроводность
        /// </summary>
        public double Transcalency
        {
            get => _transcalency;
            private set => _transcalency =
                SetCorrectValue(ParameterType.Transcalency, value, MaxTranscalency, MinTranscalency);
        }

        #endregion

        #region Private methods

        /// <summary>
        ///     Установка корректных значений параметра
        /// </summary>
        /// <param name="parameterType">Тип параметра</param>
        /// <param name="value">Проверяемое значение</param>
        /// <param name="maxValue">Максимальное значение</param>
        /// <param name="minValue">Минимальное значение</param>
        /// <returns></returns>
        private double SetCorrectValue(ParameterType parameterType, double value,
            double maxValue,
            double minValue)
        {
            if (value <= maxValue &&
                value >= minValue)
            {
                return value;
            }

            throw new ArgumentOutOfRangeException(parameterType +
                                                  ". Значение : " + value +
                                                  " не входит в диапазон допустимых значений для данного параметра от " +
                                                  minValue + " до " + maxValue);
        }

        #endregion

    }
}
