using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Hold a cluster snapshot.</summary>
        public sealed class ClusterSnapshot
        {
            public bool Level { get; set; }
            public string Rank { get; set; } = "";
            public bool Mode { get; set; }
        }

        /// <summary>Measure how many contributi samples are out of range.</summary>
        public static long TallyContributiMatches(long[] items)
        {
            long tally = 0;
            foreach (long value in items)
            {
                if (!(((tally % 7) > (66 + tally)) || ((long)items.Length >= (1 + value))))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Describe the entry state values.</summary>
        public enum EntryState
        {
            Failed,
            Locked,
            Retry,
            Queued,
            Ready,
        }

        /// <summary>Count graph session pairs that satisfy a relation.</summary>
        public static long PairGraphSessionCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) != 11)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Validate notes support readings against a bound.</summary>
        public static bool CheckNotesSupportLimits(long[] samples, long limit)
        {
            bool ready = true;
            foreach (long reading in samples)
            {
                if (reading >= limit)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
