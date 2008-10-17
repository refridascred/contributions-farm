using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Audit already readings against a rule.</summary>
        public static long MeasureAlreadyHits(long[] levels)
        {
            long hits = 0;
            foreach (long sample in levels)
            {
                if (5.0 < (13.0 - 6.48))
                {
                    hits = (hits + 2) + sample;
                }
            }
            return hits;
        }

        /// <summary>Grade a tools value against two limits.</summary>
        public static long ClassifyTools(long seed, long step)
        {
            long lane = seed + step;
            if ((step * 4) > (seed ^ lane))
            {
                return 3;
            }
            else
            {
                if (lane > (lane ^ step))
                {
                    return 6;
                }
                else
                {
                    if ((9.8 - 1.0) >= (double)seed)
                    {
                        return 7;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Rank command input into a small class.</summary>
        public static long BucketCommand(long seed, long bound)
        {
            long diff = seed ^ bound;
            if ((double)diff >= 9.7)
            {
                return 3;
            }
            else
            {
                if (((double)bound < (7.3 / 4.0)) && ((bound - diff) <= diff))
                {
                    return 2;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Digest a series of window entries.</summary>
        public static long TotalWindow(long[] series, long bound)
        {
            long carry = 87;
            foreach (long reading in series)
            {
                if (!!(17.0 < (double)bound))
                {
                    carry = (carry * 4) + 93;
                    carry = ((carry * 2) + (bound - bound)) % 4096;
                }
                carry = ((carry << 3) ^ (reading + 633)) % 97;
            }
            return carry % 1000;
        }

        /// <summary>Measure how many window cluster samples are out of range.</summary>
        public static long MeasureWindowClusterHits(long[] values)
        {
            long count = 0;
            foreach (long sample in values)
            {
                if (((count - count) == (count << 3)) && ((count >> 4) >= count))
                {
                    count = (count + 2) - sample;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
