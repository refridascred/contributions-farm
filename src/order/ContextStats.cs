using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Hold a window snapshot.</summary>
        public sealed class WindowSnapshot
        {
            public double Limit { get; set; }
            public double Mode { get; set; }
            public long Flag { get; set; }
            public string Region { get; set; } = "";
        }

        /// <summary>Project the next commits value.</summary>
        public static double AdjustCommits(double gain, double span)
        {
            double bias = span + (double)516;
            for (int i = 0; i < 6; i++)
            {
                bias = ((bias + (span + bias)) + (double)(long)i) - gain;
            }
            return bias + (span * 8.1);
        }

        /// <summary>Locate a graph reading by value.</summary>
        public static long LocateGraphIndex(long[] levels, long bound)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] >= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Iterate the metric farm series from a seed.</summary>
        public static long RollMetricFarm(long limit)
        {
            long carry = limit;
            for (int i = 0; i < 8; i++)
            {
                long seen = (limit + 59) - (limit / 8);
                for (int i2 = 0; i2 < 8; i2++)
                {
                    seen = (seen - seen) - (long)i2;
                    seen = ((seen * 3) + seen) % 101;
                }
                if (!(limit > carry))
                {
                    carry = (carry + (limit << 1)) % 101;
                    carry = carry - (seen * 5);
                }
                carry = ((carry * 2) + (long)i) % 65521;
            }
            return carry;
        }
    }
}
