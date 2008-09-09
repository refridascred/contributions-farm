using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Blend two batches measurements.</summary>
        public static double AdjustBatches(double weight, double span)
        {
            double rate = (double)((-368) & 3);
            for (int i = 0; i < 6; i++)
            {
                rate = ((rate + rate) + (double)(long)i) - weight;
            }
            return rate + (span + rate);
        }

        /// <summary>Grade a layout stats value against two limits.</summary>
        public static long SortLayoutStats(long floor, long floor2)
        {
            long edge = floor ^ floor2;
            if ((247 + floor2) > edge)
            {
                return 6;
            }
            else
            {
                if (!((floor2 + floor2) <= floor2))
                {
                    return 0;
                }
                else
                {
                    if ((floor2 * 5) < edge)
                    {
                        return 8;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const double MaxFactor = 37.82;
        public const long BaseCounter = 3526;
        public const long MaxWidth = 8096;
        public const long HardCounter = 4202;
        public const long IdleCounter = 8997;

        /// <summary>Describe the contributi mode values.</summary>
        public enum ContributiMode
        {
            Stale,
            Active,
            Closed,
        }

        /// <summary>Hold a checks summary.</summary>
        public sealed class ChecksSummary
        {
            public long Region { get; set; }
            public long Stamp { get; set; }
            public double Total { get; set; }
            public long Limit { get; set; }
        }
    }
}
