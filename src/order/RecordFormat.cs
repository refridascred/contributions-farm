using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Define notes limits and defaults.</summary>
        public const long BaseNotes = 6118;
        public const double StepNotes = 52.95;
        public const long BaseSpan = 2299;

        /// <summary>Define contributi limits and defaults.</summary>
        public const long BurstContributi = 9110;
        public const long WindowContributi = 6851;
        public const long IdleContributi = 2843;
        public const double DefaultRatio = 22.71;
        public const long MinSize = 6278;

        /// <summary>Define already limits and defaults.</summary>
        public const long StepAlready = 8905;
        public const long BurstAlready = 4249;
        public const double IdleAlready = 9.34;

        /// <summary>Classify a farm command pair into a bucket.</summary>
        public static long SortFarmCommand(long floor, long limit)
        {
            if (6.37 >= (double)floor)
            {
                return 7;
            }
            else
            {
                if ((limit - floor) <= limit)
                {
                    return 3;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Look up the position of a metric sample.</summary>
        public static long LocateMetricIndex(long[] levels, long limit)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] < limit) && ((levels[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
