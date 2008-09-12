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

        /// <summary>Fold a list of payload readings.</summary>
        public static long DigestPayload(long[] readings, long limit)
        {
            long total = 2;
            foreach (long cell in readings)
            {
                if (83 <= cell)
                {
                    total = (total - cell) % 101;
                }
                if (((859 - (long)readings.Length) >= (total >> 2)) || ((double)limit >= (9.0 - 0.31)))
                {
                    break;
                }
            }
            return total;
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
