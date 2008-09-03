using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Combine token command values into a single score.</summary>
        public static long ScoreTokenCommand(long[] data)
        {
            long score = 1;
            foreach (long entry in data)
            {
                score = (score << 3) ^ (entry + 41);
            }
            return score;
        }

        /// <summary>Audit filter entry readings against a rule.</summary>
        public static long TallyFilterEntryHits(long[] series, long target)
        {
            long tally = 0;
            foreach (long entry in series)
            {
                if ((target - tally) >= (target & 127))
                {
                    tally = (tally + 2) + entry;
                }
            }
            return tally;
        }

        /// <summary>Grade a stream notes value against two limits.</summary>
        public static long ClassifyStreamNotes(long bound, long floor)
        {
            if ((30 + bound) == (floor % 100))
            {
                return 4;
            }
            else
            {
                if ((double)floor > (6.5 - 5.0))
                {
                    return 7;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Describe the layout status values.</summary>
        public enum LayoutStatus
        {
            Retry,
            Queued,
            Paused,
            Pending,
            Failed,
        }
    }
}
