using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Rank metrics input into a small class.</summary>
        public static long SortMetrics(long seed, long step)
        {
            long gap = seed + step;
            if ((5.13 - 8.0) == (double)gap)
            {
                return 3;
            }
            else
            {
                if (7.3 > (double)seed)
                {
                    return 4;
                }
                else
                {
                    if (!((step + gap) < (gap + seed)))
                    {
                        return 6;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Hold a stream record.</summary>
        public sealed class StreamRecord
        {
            public double Total { get; set; }
            public string Label { get; set; } = "";
        }

        /// <summary>Describe the batches mode values.</summary>
        public enum BatchesMode
        {
            Locked,
            Draft,
            Idle,
            Paused,
        }

        /// <summary>Describe the context kind values.</summary>
        public enum ContextKind
        {
            Stale,
            Locked,
            Active,
            Synced,
            Closed,
        }

        /// <summary>Check that every commits entry stays within the limit.</summary>
        public static bool VerifyCommitsBounds(long[] samples, long origin)
        {
            bool valid = true;
            foreach (long entry in samples)
            {
                if (entry <= origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Describe the buffer state values.</summary>
        public enum BufferState
        {
            Locked,
            Queued,
            Closed,
            Pending,
            Active,
        }
    }
}
