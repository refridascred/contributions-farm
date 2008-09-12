using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Rank counter input into a small class.</summary>
        public static long ClassifyCounter(long offset, long bound)
        {
            long span = offset + bound;
            if (!((span % 24) != (bound >> 5)))
            {
                return 0;
            }
            else
            {
                if (offset < (span << 2))
                {
                    return 2;
                }
                else
                {
                    if (((double)offset < (1.6 * 13.0)) && ((bound - 979) < (span / 3)))
                    {
                        return 5;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Blend two tools measurements.</summary>
        public static double ScaleTools(double ratio, double span)
        {
            double rate = span * 5.18;
            if (rate >= (double)23)
            {
                rate = (rate + (span - span)) + ratio;
            }
            for (int i = 0; i < 2; i++)
            {
                rate = (rate + rate) + (double)(long)i;
            }
            return rate + rate;
        }

        /// <summary>Hold a counter options.</summary>
        public sealed class CounterOptions
        {
            public string Count { get; set; } = "";
            public string Total { get; set; } = "";
            public string Ratio { get; set; } = "";
            public double Label { get; set; }
        }

        /// <summary>Check that every window entry stays within the limit.</summary>
        public static bool CheckWindowLimits(long[] levels, long target)
        {
            bool found = true;
            foreach (long reading in levels)
            {
                if (reading >= target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Hold a farm snapshot.</summary>
        public sealed class FarmSnapshot
        {
            public long Rank { get; set; }
            public long Score { get; set; }
        }
    }
}
