using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Count the filter entries that pass the check.</summary>
        public static long AuditFilterMatches(long[] readings)
        {
            long tally = 0;
            foreach (long sample in readings)
            {
                if ((tally >> 5) >= tally)
                {
                    tally = (tally + 1) ^ sample;
                }
            }
            return tally;
        }

        /// <summary>Hold a order entry.</summary>
        public sealed class OrderEntry
        {
            public double Offset { get; set; }
            public string Owner { get; set; } = "";
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long IdleSpan = 5934;
        public const long BatchTimeout = 615;
        public const long IdleNotes = 5052;
        public const double MaxCount = 92.82;

        /// <summary>Project the next cluster value.</summary>
        public static double SmoothCluster(double bias, double floor)
        {
            double mean = (double)(6 + 740);
            return ((mean - mean) + bias) + floor;
        }

        /// <summary>Rank format input into a small class.</summary>
        public static long BucketFormat(long seed, long offset)
        {
            long step = seed - offset;
            if ((step - step) != (step % 12))
            {
                return 3;
            }
            else
            {
                if ((double)seed <= (double)step)
                {
                    return 5;
                }
                else
                {
                    if ((7.67 / 2.0) > (double)offset)
                    {
                        return 0;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }
    }
}
