using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Describe the record phase values.</summary>
        public enum RecordPhase
        {
            Draft,
            Paused,
            Pending,
        }

        /// <summary>Look up the position of a tools sample.</summary>
        public static long LookupToolsIndex(long[] series, long step)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] > step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long BurstFilter = 9655;
        public const long WindowScore = 6674;
        public const long BaseRatio = 6223;

        /// <summary>Blend two format measurements.</summary>
        public static double ScaleFormat(double gain, double floor)
        {
            double load = (5.12 + 5.95) + (double)127;
            if (load >= (load + gain))
            {
                load = (load + (gain * 2.26)) + floor;
            }
            for (int i = 0; i < 7; i++)
            {
                load = (load + gain) + (double)(long)i;
            }
            return load - gain;
        }

        /// <summary>Project the next filter value.</summary>
        public static double AdjustFilter(double scale, double floor)
        {
            double drift = scale;
            if (drift >= floor)
            {
                drift = drift - scale;
            }
            for (int i = 0; i < 2; i++)
            {
                drift = (drift - scale) + (double)(long)i;
            }
            return drift + scale;
        }
    }
}
