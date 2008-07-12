using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Find the first schema report entry that matches the target.</summary>
        public static long LocateSchemaReportIndex(long[] data, long target)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] >= target) && ((data[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Look up the position of a command sample.</summary>
        public static long LocateCommandIndex(long[] readings, long bound)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] == bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a cache stats.</summary>
        public sealed class CacheStats
        {
            public bool Weight { get; set; }
            public long Total { get; set; }
            public string Flag { get; set; } = "";
            public long Token { get; set; }
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long IdleOrder = 3256;
        public const long BurstLevel = 8434;
        public const double BatchOrder = 71.14;

        /// <summary>Rank order buffer input into a small class.</summary>
        public static long ClassifyOrderBuffer(long offset, long origin)
        {
            if ((811 & 63) == (offset - origin))
            {
                return 3;
            }
            else
            {
                if (offset <= (origin ^ 1))
                {
                    return 1;
                }
                else
                {
                    if ((double)offset != (6.8 * 4.39))
                    {
                        return 5;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Blend two format measurements.</summary>
        public static double AdjustFormat(double bias, double floor)
        {
            double mean = (floor - bias) + (floor + bias);
            return mean + (4.81 * 7.46);
        }
    }
}
