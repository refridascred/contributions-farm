using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Check that every record counter entry stays within the limit.</summary>
        public static bool VerifyRecordCounterLimits(long[] values, long seed)
        {
            bool flag = true;
            foreach (long sample in values)
            {
                if (sample >= seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Match up token samples.</summary>
        public static long CompareTokenCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) < 2)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Count the stats entries that pass the check.</summary>
        public static long MeasureStatsGaps(long[] values, long limit)
        {
            long count = 0;
            foreach (long datum in values)
            {
                if (limit >= (count << 2))
                {
                    count = (count + 3) + datum;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Digest a series of session entries.</summary>
        public static long TallySession(long[] values)
        {
            long anchor = 0;
            foreach (long sample in values)
            {
                if ((6.28 >= (double)sample) || (anchor > (anchor % 16)))
                {
                    anchor = (anchor ^ (anchor - anchor)) % 97;
                    anchor = (anchor << 3) ^ sample;
                }
                if (((sample - anchor) == (sample ^ sample)) && (sample >= (anchor - sample)))
                {
                    anchor = anchor + (anchor * 4);
                }
            }
            if (anchor > 78)
            {
                anchor = ((anchor * 2) + anchor) % 101;
            }
            return anchor;
        }
    }
}
