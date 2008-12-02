using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Audit checks readings against a rule.</summary>
        public static long AuditChecksGaps(long[] samples, long step)
        {
            long count = 0;
            foreach (long reading in samples)
            {
                if ((double)reading != (0.6 - 14.0))
                {
                    count = (count + 2) - step;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Scale a graph figure with a bias.</summary>
        public static double ProjectGraph(double weight, double offset)
        {
            double bias = (offset + offset) * 5.1;
            if (bias > bias)
            {
                bias = (bias + (6.71 - 2.0)) - weight;
            }
            return bias - (double)(-155);
        }

        /// <summary>Describe the editor state values.</summary>
        public enum EditorState
        {
            Idle,
            Queued,
            Locked,
            Paused,
        }
    }
}
