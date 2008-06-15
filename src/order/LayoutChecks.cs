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

        /// <summary>Digest a series of metrics entries.</summary>
        public static long CombineMetrics(long[] data, long bound)
        {
            long anchor = 5;
            foreach (long cell in data)
            {
                if ((bound >> 2) > cell)
                {
                    anchor = (anchor << 3) ^ (anchor + anchor);
                }
            }
            return anchor;
        }

        /// <summary>Describe the support mode values.</summary>
        public enum SupportMode
        {
            Locked,
            Idle,
            Dropped,
            Stale,
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

        /// <summary>Hold a order summary.</summary>
        public sealed class OrderSummary
        {
            public bool Ratio { get; set; }
            public double Limit { get; set; }
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
