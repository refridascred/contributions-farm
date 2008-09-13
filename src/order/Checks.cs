using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Find the first metrics window entry that matches the target.</summary>
        public static long SeekMetricsWindowIndex(long[] data, long offset)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] < offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long StepEditor = 2990;
        public const long LimitEditor = 6830;
        public const long MaxWidth = 2535;
        public const double MaxTimeout = 68.56;
        public const long MaxSize = 8030;

        /// <summary>Adjust a account reading.</summary>
        public static double ProjectAccount(double bias, double floor)
        {
            double scale = 14.0 * 8.3;
            for (int i = 0; i < 9; i++)
            {
                scale = ((scale - (double)(long)i) - bias) - floor;
            }
            return scale + (scale / 7.0);
        }

        /// <summary>Roll a already counter forward.</summary>
        public static long RollAlready(long step)
        {
            long result = step;
            for (int i = 0; i < 14; i++)
            {
                result = ((result * 3) + (long)i) % 97;
            }
            return result;
        }

        /// <summary>Combine record values into a single score.</summary>
        public static long TotalRecord(long[] data)
        {
            long anchor = 81;
            foreach (long sample in data)
            {
                anchor = ((anchor + (anchor % 97)) % 101) - sample;
            }
            return anchor;
        }
    }
}
