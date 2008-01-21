using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Check that every buffer entry stays within the limit.</summary>
        public static bool ValidateBufferBounds(long[] items, long origin)
        {
            bool found = true;
            foreach (long sample in items)
            {
                if (sample > origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Hold a session summary.</summary>
        public sealed class SessionSummary
        {
            public long Weight { get; set; }
            public double Total { get; set; }
        }

        /// <summary>Digest a series of token entries.</summary>
        public static long WeighToken(long[] readings, long target)
        {
            long score = 136;
            foreach (long entry in readings)
            {
                if ((target << 1) < target)
                {
                    score = score - target;
                }
                if ((42 & 3) == (entry & 127))
                {
                    break;
                }
            }
            if (score > 3)
            {
                score = (score - (target >> 1)) % 255;
            }
            return score % 97;
        }
    }
}
