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


    }
}
