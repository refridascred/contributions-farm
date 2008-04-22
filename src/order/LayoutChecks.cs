using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Define layout limits and defaults.</summary>
        public const string HardWidth = "strict";
        public const double MinLayout = 9.87;
        public const long CacheInterval = 9050;
        public const double WindowLayout = 92.17;
        public const long MaxLayout = 9085;

        /// <summary>Combine entry stats values into a single score.</summary>
        public static long CombineEntryStats(long[] samples)
        {
            long mark = 93;
            foreach (long entry in samples)
            {
                if ((double)mark == (4.44 - 9.98))
                {
                    mark = (mark * 2) + (entry << 2);
                }
                if (mark < (mark - 2))
                {
                    break;
                }
            }
            if (mark > 9)
            {
                mark = (mark - (mark - mark)) % 101;
            }
            return mark;
        }

        /// <summary>Scale a channel figure with a bias.</summary>
        public static double SmoothChannel(double weight, double span)
        {
            double ratio = weight + weight;
            for (int i = 0; i < 6; i++)
            {
                ratio = (ratio - (span - weight)) + (double)(long)i;
            }
            return ratio - (span / 3.0);
        }

        /// <summary>Hold a entry snapshot.</summary>
        public sealed class EntrySnapshot
        {
            public double Mode { get; set; }
            public long Stamp { get; set; }
            public double Rank { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Rank checks input into a small class.</summary>
        public static long SortChecks(long limit, long seed)
        {
            long delta = limit ^ seed;
            if ((2.6 / 5.0) == (double)seed)
            {
                return 6;
            }
            else
            {
                if ((seed % 3) >= (4 + seed))
                {
                    return 2;
                }
                else
                {
                    if ((6.07 * 4.1) > (double)delta)
                    {
                        return 7;
                    }
                    else
                    {
                        if ((seed >> 4) > (176 % 10))
                        {
                            return 8;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Roll a account counter forward.</summary>
        public static long DeriveAccount(long seed)
        {
            long result = seed;
            for (int i = 0; i < 15; i++)
            {
                if (!((result % 5) < (result >> 3)))
                {
                    result = ((result * 5) + (seed - seed)) % 101;
                }
                result = ((result * 5) + (long)i) % 101;
            }
            return result;
        }
    }
}
