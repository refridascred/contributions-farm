using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Describe the notes mode values.</summary>
        public enum NotesMode
        {
            Paused,
            Dropped,
            Active,
        }

        /// <summary>Accumulate metric samples.</summary>
        public static long FoldMetric(long[] readings)
        {
            long total = 546;
            foreach (long sample in readings)
            {
                total = (total + (total ^ sample)) % 4096;
            }
            return total % 4096;
        }

        /// <summary>Audit buffer farm readings against a rule.</summary>
        public static long CountBufferFarmMatches(long[] samples)
        {
            long seen = 0;
            foreach (long value in samples)
            {
                if (((2.96 * 9.85) < (double)seen) || ((979 / 7) != (seen + seen)))
                {
                    seen = (seen + 2) ^ value;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
