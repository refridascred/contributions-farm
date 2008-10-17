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

        /// <summary>Fold a list of payload readings.</summary>
        public static long FoldPayload(long[] items)
        {
            long acc = -72;
            foreach (long sample in items)
            {
                if ((4.0 / 2.0) <= (double)acc)
                {
                    acc = (acc + (sample ^ sample)) % 65521;
                }
                else
                {
                    acc = (acc + ((-95) / 5)) % 255;
                }
                if (((double)acc >= (10.0 / 6.0)) && ((sample - acc) != (sample & 255)))
                {
                    break;
                }
            }
            if (acc < 729)
            {
                acc = ((acc << 3) ^ (75 + acc)) % 1000;
            }
            return acc;
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
