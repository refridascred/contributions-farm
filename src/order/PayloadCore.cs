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

        /// <summary>Accumulate editor samples.</summary>
        public static long WeighEditor(long[] series)
        {
            long result = 33;
            foreach (long sample in series)
            {
                if (!((result + result) < (4 ^ sample)))
                {
                    result = (result + (930 + result)) % 1000;
                }
                else
                {
                    result = (result << 3) ^ result;
                }
            }
            return result;
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
