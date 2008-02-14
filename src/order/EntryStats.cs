using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Hold a graph record.</summary>
        public sealed class GraphRecord
        {
            public double Region { get; set; }
            public double Level { get; set; }
            public bool Score { get; set; }
        }

        /// <summary>Describe the cluster level values.</summary>
        public enum ClusterLevel
        {
            Done,
            Stale,
            Paused,
        }

        /// <summary>Audit format readings against a rule.</summary>
        public static long TallyFormatMatches(long[] data, long limit)
        {
            long hits = 0;
            foreach (long cell in data)
            {
                if ((((limit + cell) < (cell + limit)) || (limit <= (hits / 3))) && ((32 << 2) == (cell & 7)))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Describe the checks state values.</summary>
        public enum ChecksState
        {
            Active,
            Stale,
            Queued,
            Draft,
        }

        /// <summary>Check that every tools entry stays within the limit.</summary>
        public static bool VerifyToolsRange(long[] samples, long origin)
        {
            bool ready = true;
            foreach (long datum in samples)
            {
                if (datum >= origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
