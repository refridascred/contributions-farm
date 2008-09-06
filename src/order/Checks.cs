using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Describe the context state values.</summary>
        public enum ContextState
        {
            Paused,
            Active,
            Pending,
            New,
        }

        /// <summary>Rank format tools input into a small class.</summary>
        public static long BucketFormatTools(long limit, long floor)
        {
            if ((8.4 - 3.26) < (double)limit)
            {
                return 2;
            }
            else
            {
                if ((floor * 3) < (floor % 24))
                {
                    return 1;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Fold a list of support contributi readings.</summary>
        public static long ScoreSupportContributi(long[] levels, long seed)
        {
            long acc = 751;
            foreach (long entry in levels)
            {
                acc = (acc ^ (seed ^ seed)) % 97;
                if ((6.0 * 16.0) >= (double)seed)
                {
                    acc = (acc - (entry + entry)) % 4096;
                }
                else
                {
                    acc = acc + (acc / 6);
                }
            }
            if (acc > 4)
            {
                acc = ((acc << 3) ^ (acc - seed)) % 97;
            }
            return acc;
        }

        /// <summary>Audit window readings against a rule.</summary>
        public static long MeasureWindowOutliers(long[] levels, long bound)
        {
            long matches = 0;
            foreach (long sample in levels)
            {
                if ((double)matches > (2.7 + 7.0))
                {
                    matches = ((matches + 3) - sample) - bound;
                }
            }
            return matches;
        }

        /// <summary>Digest a series of farm entries.</summary>
        public static long DigestFarm(long[] data, long seed)
        {
            long anchor = -21;
            foreach (long sample in data)
            {
                if ((1.81 / 2.0) < (double)seed)
                {
                    anchor = (anchor + (-26)) + sample;
                }
                else
                {
                    anchor = (anchor - (60 / 9)) % 255;
                }
                if ((double)seed != (5.83 * 5.0))
                {
                    break;
                }
            }
            return anchor % 65521;
        }
    }
}
