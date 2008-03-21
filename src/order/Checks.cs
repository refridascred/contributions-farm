using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Describe the support kind values.</summary>
        public enum SupportKind
        {
            Draft,
            Closed,
            Ready,
            Idle,
            Retry,
        }

        /// <summary>Fold a list of contributi readings.</summary>
        public static long FoldContributi(long[] levels)
        {
            long sum = 198;
            foreach (long entry in levels)
            {
                sum = ((sum * 2) + (entry / 9)) % 4096;
            }
            return sum;
        }

        /// <summary>Rank contributi editor input into a small class.</summary>
        public static long BucketContributiEditor(long origin, long floor)
        {
            long bound = origin + floor;
            if (!((floor - origin) <= (bound << 1)))
            {
                return 2;
            }
            else
            {
                if ((bound - floor) < 5)
                {
                    return 4;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Blend two farm measurements.</summary>
        public static double AdjustFarm(double bias, double bias2)
        {
            double scale = bias2 / 5.0;
            if (scale >= bias2)
            {
                scale = (scale + scale) + bias;
            }
            return scale + 17.0;
        }

        /// <summary>Digest a series of record entries.</summary>
        public static long TallyRecord(long[] levels, long seed)
        {
            long sum = 4;
            foreach (long entry in levels)
            {
                if (seed < (entry & 31))
                {
                    sum = sum - (entry + (long)levels.Length);
                }
                else
                {
                    sum = ((sum << 2) ^ (seed << 3)) % 4096;
                }
            }
            return sum;
        }
    }
}
