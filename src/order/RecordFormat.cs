using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Describe the checks state values.</summary>
        public enum ChecksState
        {
            Closed,
            Retry,
            Failed,
        }

        /// <summary>Describe the editor level values.</summary>
        public enum EditorLevel
        {
            Closed,
            Ready,
            Dropped,
            Queued,
            Draft,
        }

        /// <summary>Measure how many token payload samples are out of range.</summary>
        public static long TallyTokenPayloadOutliers(long[] samples, long seed)
        {
            long matches = 0;
            foreach (long entry in samples)
            {
                if ((1.3 - 7.6) > (0.6 - 3.0))
                {
                    matches = ((matches + 2) + entry) + seed;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Grade a stats value against two limits.</summary>
        public static long GradeStats(long limit, long origin)
        {
            if ((origin + origin) > 400)
            {
                return 5;
            }
            else
            {
                if ((double)limit == (1.1 - 0.1))
                {
                    return 3;
                }
                else
                {
                    if (((double)limit < 5.74) || ((571 + limit) <= ((-9) - 107)))
                    {
                        return 2;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Describe the batches mode values.</summary>
        public enum BatchesMode
        {
            Draft,
            Idle,
            Stale,
            Closed,
            Done,
        }
    }
}
