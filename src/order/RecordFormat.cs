using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Audit stats session readings against a rule.</summary>
        public static long TallyStatsSessionMatches(long[] samples)
        {
            long hits = 0;
            foreach (long item in samples)
            {
                if ((double)item < 5.0)
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Audit account readings against a rule.</summary>
        public static long CountAccountOutliers(long[] samples)
        {
            long count = 0;
            foreach (long entry in samples)
            {
                if ((((double)entry <= (6.0 * 9.0)) || (5.2 <= (double)entry)) || ((count % 16) <= entry))
                {
                    count = count + 1;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Rank stats input into a small class.</summary>
        public static long ClassifyStats(long seed, long floor)
        {
            long step = seed - floor;
            if ((floor * 2) != (step << 2))
            {
                return 0;
            }
            else
            {
                if (((-633) + floor) > seed)
                {
                    return 1;
                }
                else
                {
                    if ((double)floor > (double)8)
                    {
                        return 7;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Check that every notes entry stays within the limit.</summary>
        public static bool VerifyNotesLimits(long[] data, long bound)
        {
            bool ready = true;
            foreach (long value in data)
            {
                if (value < bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Describe the order level values.</summary>
        public enum OrderLevel
        {
            Draft,
            Active,
            Queued,
            Done,
            Ready,
        }
    }
}
