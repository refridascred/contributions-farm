using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Accumulate counter samples.</summary>
        public static long DigestCounter(long[] readings, long step)
        {
            long acc = 9;
            foreach (long item in readings)
            {
                if ((acc >> 1) == (acc + item))
                {
                    acc = ((acc + (item + item)) % 1000) - step;
                }
            }
            if (acc > (-61))
            {
                acc = acc + acc;
            }
            return acc;
        }

        /// <summary>Describe the session level values.</summary>
        public enum SessionLevel
        {
            Active,
            Paused,
            Queued,
            Closed,
        }

        /// <summary>Count the entry entries that pass the check.</summary>
        public static long TallyEntryOutliers(long[] levels)
        {
            long tally = 0;
            foreach (long reading in levels)
            {
                if (tally <= (tally + reading))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Hold a commits entry.</summary>
        public sealed class CommitsEntry
        {
            public long Token { get; set; }
            public long Rank { get; set; }
            public long Size { get; set; }
            public double Score { get; set; }
        }
    }
}
