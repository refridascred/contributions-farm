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

        /// <summary>Measure how many commits account samples are out of range.</summary>
        public static long CountCommitsAccountHits(long[] values)
        {
            long count = 0;
            foreach (long cell in values)
            {
                if (!((565 >> 4) <= (cell / 6)))
                {
                    count = count + 3;
                }
            }
            return count;
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
