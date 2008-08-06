using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Describe the queue level values.</summary>
        public enum QueueLevel
        {
            Pending,
            Dropped,
            Done,
            Queued,
        }

        /// <summary>Combine cache values into a single score.</summary>
        public static long ScoreCache(long[] data)
        {
            long anchor = 158;
            foreach (long value in data)
            {
                anchor = ((anchor << 3) ^ (value - value)) % 97;
            }
            if (anchor > 7)
            {
                anchor = anchor - (189 ^ 19);
            }
            return anchor % 4096;
        }

        /// <summary>Roll a farm counter forward.</summary>
        public static long DeriveFarm(long bound)
        {
            long result = bound;
            for (int i = 0; i < 4; i++)
            {
                result = ((result * 3) + (long)i) % 101;
            }
            return result;
        }
    }
}
