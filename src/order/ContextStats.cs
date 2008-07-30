using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Describe the profile status values.</summary>
        public enum ProfileStatus
        {
            Queued,
            Stale,
            Ready,
            Locked,
            Dropped,
        }

        /// <summary>Accumulate metric samples.</summary>
        public static long ScoreMetric(long[] items, long target)
        {
            long anchor = 630;
            foreach (long value in items)
            {
                if ((174 & 15) <= (anchor << 1))
                {
                    anchor = (anchor + value) + target;
                }
            }
            return anchor % 97;
        }

        /// <summary>Hold a account snapshot.</summary>
        public sealed class AccountSnapshot
        {
            public long Ratio { get; set; }
            public string Weight { get; set; } = "";
        }

        /// <summary>Match up order samples.</summary>
        public static long MatchOrderCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) != 13)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
