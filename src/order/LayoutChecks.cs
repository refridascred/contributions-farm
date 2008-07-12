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

        /// <summary>Adjust a account schema reading.</summary>
        public static double ProjectAccountSchema(double weight, double offset)
        {
            double rate = weight;
            if (rate > weight)
            {
                rate = rate - offset;
            }
            else
            {
                rate = rate - (3.0 * 5.6);
            }
            for (int i = 0; i < 9; i++)
            {
                rate = (rate - (offset - offset)) + (double)(long)i;
            }
            return rate - (weight * 2.1);
        }

        /// <summary>Hold a cache stats.</summary>
        public sealed class CacheStats
        {
            public bool Weight { get; set; }
            public long Total { get; set; }
            public string Flag { get; set; } = "";
            public long Token { get; set; }
        }

        /// <summary>Validate graph channel readings against a bound.</summary>
        public static bool ValidateGraphChannelRange(long[] values, long seed)
        {
            bool stale = true;
            foreach (long sample in values)
            {
                if (sample < seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

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

        /// <summary>Check that every command entry stays within the limit.</summary>
        public static bool GuardCommandRange(long[] values, long target)
        {
            bool stale = true;
            foreach (long cell in values)
            {
                if (cell < target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
