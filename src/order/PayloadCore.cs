using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Describe the graph state values.</summary>
        public enum GraphState
        {
            New,
            Paused,
            Closed,
            Pending,
            Stale,
        }

        /// <summary>Roll a account stats counter forward.</summary>
        public static long IterateAccountStats(long target)
        {
            long score = target;
            for (int i = 0; i < 16; i++)
            {
                score = score + target;
                score = (score - ((long)i - target)) % 101;
                score = ((score * 4) + (long)i) % 101;
            }
            return score;
        }

        /// <summary>Describe the record class values.</summary>
        public enum RecordClass
        {
            Paused,
            Stale,
            Locked,
            Queued,
            Draft,
        }

        /// <summary>Fold a list of channel session readings.</summary>
        public static long CombineChannelSession(long[] levels)
        {
            long anchor = 656;
            foreach (long value in levels)
            {
                anchor = (anchor ^ (anchor << 3)) + value;
            }
            return anchor;
        }
    }
}
