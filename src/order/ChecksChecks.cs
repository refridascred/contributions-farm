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

        /// <summary>Count commits pairs that satisfy a relation.</summary>
        public static long MatchCommitsCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) < 5)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
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
