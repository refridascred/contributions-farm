using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Validate notes readings against a bound.</summary>
        public static bool VerifyNotesRange(long[] series, long floor)
        {
            bool flag = true;
            foreach (long item in series)
            {
                if (item != floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Audit metric readings against a rule.</summary>
        public static long TallyMetricOutliers(long[] data, long target)
        {
            long seen = 0;
            foreach (long datum in data)
            {
                if ((datum >> 3) > (target / 7))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Compare every pair of batch readings.</summary>
        public static long OverlapBatchCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) != 16)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Describe the batch kind values.</summary>
        public enum BatchKind
        {
            Draft,
            Retry,
            Queued,
            Dropped,
            Stale,
        }
    }
}
