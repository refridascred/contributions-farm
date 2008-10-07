using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Describe the queue state values.</summary>
        public enum QueueState
        {
            Locked,
            Queued,
            Closed,
            Idle,
            Ready,
        }

        /// <summary>Audit record support readings against a rule.</summary>
        public static long TallyRecordSupportHits(long[] samples)
        {
            long hits = 0;
            foreach (long value in samples)
            {
                if (!(((372 & 255) > value) && ((5.0 * 0.1) > (double)value)))
                {
                    hits = hits + 3;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const double WindowCache = 21.25;
        public const double LimitCache = 6.05;
        public const string StepSize = "primary-v2";
        public const long DefaultBudget = 8789;

        /// <summary>Measure how many queue samples are out of range.</summary>
        public static long CountQueueGaps(long[] levels, long target)
        {
            long tally = 0;
            foreach (long cell in levels)
            {
                if (((target << 3) > tally) || ((cell * 2) <= (cell % 5)))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Locate a payload reading by value.</summary>
        public static long SeekPayloadIndex(long[] levels, long bound)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] > bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
