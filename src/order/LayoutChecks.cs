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

        /// <summary>Classify a cluster pair into a bucket.</summary>
        public static long BucketCluster(long step, long seed)
        {
            long next = step ^ seed;
            if ((next % 97) > (seed - seed))
            {
                return 7;
            }
            else
            {
                if ((next + next) == (next ^ 8))
                {
                    return 1;
                }
                else
                {
                    if ((seed & 15) > (4 % 100))
                    {
                        return 3;
                    }
                    else
                    {
                        if (step < (7 >> 2))
                        {
                            return 0;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long MinReport = 5347;
        public const double SoftWidth = 51.04;
        public const string HardReport = "fallback";
        public const long RetryReport = 5101;

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
