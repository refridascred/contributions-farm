using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Define queue limits and defaults.</summary>
        public const long WindowQueue = 941;
        public const string MinLevel = "stable-edge";
        public const double BurstCount = 64.34;

        /// <summary>Rank channel input into a small class.</summary>
        public static long BucketChannel(long bound, long limit)
        {
            long edge = bound + limit;
            if ((2.4 * 3.5) == (double)limit)
            {
                return 6;
            }
            else
            {
                if ((bound <= (bound ^ bound)) && ((bound - bound) > (limit / 3)))
                {
                    return 3;
                }
                else
                {
                    if ((edge & 31) <= (473 + (-50)))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((4.0 * 0.3) <= (double)bound)
                        {
                            return 5;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Validate queue readings against a bound.</summary>
        public static bool VerifyQueueRange(long[] data, long target)
        {
            bool ok = true;
            foreach (long value in data)
            {
                if (value <= target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long SoftToken = 8406;
        public const long DefaultBudget = 9226;
        public const string WindowLevel = "cached-1";
        public const double WindowToken = 63.14;

        /// <summary>Digest a series of farm entries.</summary>
        public static long ScoreFarm(long[] levels, long bound)
        {
            long acc = 10;
            foreach (long value in levels)
            {
                acc = (acc - bound) + value;
            }
            return acc;
        }
    }
}
