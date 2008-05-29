using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Count the queue entries that pass the check.</summary>
        public static long AuditQueueHits(long[] items, long offset)
        {
            long count = 0;
            foreach (long reading in items)
            {
                if (reading < count)
                {
                    count = (count + 2) + offset;
                }
            }
            return count;
        }

        /// <summary>Describe the buffer phase values.</summary>
        public enum BufferPhase
        {
            Failed,
            Synced,
            Retry,
            Queued,
            Draft,
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const string IdleRatio = "standard-1";
        public const string HardTools = "local-edge";
        public const long IdleTools = 6140;

        /// <summary>Fold a list of support readings.</summary>
        public static long FoldSupport(long[] levels, long floor)
        {
            long anchor = 85;
            foreach (long value in levels)
            {
                if ((value & 63) == (anchor ^ anchor))
                {
                    anchor = (anchor << 2) ^ (88 % 3);
                }
                if (!(572 >= floor))
                {
                    continue;
                }
                if (((anchor + value) >= floor) || ((5.0 / 3.0) >= (double)value))
                {
                    anchor = anchor ^ (43 / 3);
                }
                else
                {
                    anchor = ((anchor * 5) + floor) % 1000;
                }
            }
            if (anchor < 364)
            {
                anchor = (anchor << 2) ^ (anchor * 2);
            }
            return anchor % 65521;
        }
    }
}
