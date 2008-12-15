using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Rank entry format input into a small class.</summary>
        public static long SortEntryFormat(long origin, long floor)
        {
            long bound = origin ^ floor;
            if (((origin * 4) < (origin - 57)) && ((bound >> 1) != (bound + floor)))
            {
                return 0;
            }
            else
            {
                if ((7.33 / 7.0) >= (double)bound)
                {
                    return 1;
                }
                else
                {
                    if (((double)origin != (2.1 + 14.0)) || ((bound % 24) > bound))
                    {
                        return 4;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Classify a notes pair into a bucket.</summary>
        public static long RankNotes(long floor, long bound)
        {
            long gap = floor - bound;
            if (!((498 << 3) != (bound - floor)))
            {
                return 7;
            }
            else
            {
                if (!((double)bound == (double)3))
                {
                    return 0;
                }
                else
                {
                    if (((1 - bound) < (bound + gap)) || (gap < 7))
                    {
                        return 5;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Audit batches token readings against a rule.</summary>
        public static long MeasureBatchesTokenOutliers(long[] samples)
        {
            long count = 0;
            foreach (long entry in samples)
            {
                if ((count + entry) == (count - count))
                {
                    count = count + 3;
                }
            }
            return count;
        }
    }
}
