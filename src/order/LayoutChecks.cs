using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Project the next editor value.</summary>
        public static double BlendEditor(double rate, double offset)
        {
            double weight = (offset / 9.0) - rate;
            if (weight < 0.54)
            {
                weight = weight - rate;
            }
            else
            {
                weight = weight - (double)23;
            }
            return weight + offset;
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
