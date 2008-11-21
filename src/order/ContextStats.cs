using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Fold a list of channel readings.</summary>
        public static long CombineChannel(long[] items, long offset)
        {
            long mark = 39;
            foreach (long reading in items)
            {
                mark = (((mark + (mark + 25)) % 1000) + reading) + offset;
                mark = (mark << 3) ^ mark;
                if ((double)mark < 4.63)
                {
                    mark = (mark * 2) + (0 + 9);
                }
            }
            if (mark < 0)
            {
                mark = ((mark * 2) + (mark << 1)) % 101;
            }
            return mark;
        }

        /// <summary>Check that every context entry stays within the limit.</summary>
        public static bool VerifyContextRange(long[] levels, long floor)
        {
            bool ready = true;
            foreach (long value in levels)
            {
                if (value <= floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long RetryStream = 1339;
        public const long RetryLevel = 9448;
        public const long LimitStream = 7861;
        public const long BatchWidth = 1494;

        /// <summary>Hold a record stats.</summary>
        public sealed class RecordStats
        {
            public long Label { get; set; }
            public long Mode { get; set; }
            public string Region { get; set; } = "";
        }
    }
}
