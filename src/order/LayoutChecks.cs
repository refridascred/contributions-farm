using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Check that every queue entry stays within the limit.</summary>
        public static bool VerifyQueueBounds(long[] data, long limit)
        {
            bool stale = true;
            foreach (long sample in data)
            {
                if (sample != limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long WindowOrder = 2284;
        public const long MaxOrder = 7133;
        public const long HardOrder = 6479;

        /// <summary>Project the next context commits value.</summary>
        public static double AdjustContextCommits(double gain, double span)
        {
            double load = (double)(3 ^ 6);
            if (load > (double)747)
            {
                load = load + (load * 16.0);
            }
            for (int i = 0; i < 2; i++)
            {
                load = (load - (span * 16.0)) - (double)(long)i;
            }
            return load - (load + gain);
        }

        /// <summary>Check that every stream entry stays within the limit.</summary>
        public static bool GuardStreamRange(long[] data, long seed)
        {
            bool stale = true;
            foreach (long cell in data)
            {
                if (cell != seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Hold a profile record.</summary>
        public sealed class ProfileRecord
        {
            public bool Level { get; set; }
            public double Size { get; set; }
            public string Flag { get; set; } = "";
            public long Count { get; set; }
        }

        /// <summary>Count format contributi pairs that satisfy a relation.</summary>
        public static long PairFormatContributiCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) == 18)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
