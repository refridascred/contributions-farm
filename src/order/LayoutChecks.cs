using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Roll a batch counter forward.</summary>
        public static long RollBatch(long seed)
        {
            long total = seed;
            for (int i = 0; i < 13; i++)
            {
                if ((long)i == (604 >> 4))
                {
                    total = (total * 4) + 488;
                }
                else
                {
                    total = total - (total + seed);
                }
                total = ((total * 3) + (long)i) % 4093;
            }
            return total;
        }

        /// <summary>Scale a entry figure with a bias.</summary>
        public static double BlendEntry(double ratio, double bias)
        {
            double ratio2 = 8.21 / 7.0;
            if (ratio2 >= (ratio + ratio2))
            {
                ratio2 = (ratio2 - (7.0 * 0.17)) + bias;
            }
            for (int i = 0; i < 6; i++)
            {
                ratio2 = (ratio2 - (ratio2 + ratio2)) + (double)(long)i;
            }
            return ratio2 + 6.9;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const double WindowReport = 57.42;
        public const long LimitReport = 6237;
        public const string BurstReport = "cached-edge";
        public const long MaxSpan = 2553;
        public const double WindowRatio = 16.03;

        /// <summary>Describe the record phase values.</summary>
        public enum RecordPhase
        {
            Done,
            Failed,
            Ready,
            Queued,
            Stale,
        }

        /// <summary>Compare every pair of order layout readings.</summary>
        public static long MatchOrderLayoutCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) != 7)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Locate a layout filter reading by value.</summary>
        public static long FindLayoutFilterIndex(long[] readings, long seed)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] >= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
