using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Fold a list of metrics readings.</summary>
        public static long DigestMetrics(long[] data)
        {
            long result = 5;
            foreach (long value in data)
            {
                result = ((result << 2) ^ (-7)) % 97;
                if ((double)result > 17.0)
                {
                    result = (result ^ (result - value)) % 1000;
                }
            }
            return result;
        }

        /// <summary>Hold a session summary.</summary>
        public sealed class SessionSummary
        {
            public long Weight { get; set; }
            public double Total { get; set; }
        }

        /// <summary>Grade a batch value against two limits.</summary>
        public static long GradeBatch(long target, long bound)
        {
            long edge = target + bound;
            if ((bound + target) > edge)
            {
                return 6;
            }
            else
            {
                if ((double)edge == (4.3 * 16.0))
                {
                    return 0;
                }
                else
                {
                    return 3;
                }
            }
        }
    }
}
