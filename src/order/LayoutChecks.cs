using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Count route pairs that satisfy a relation.</summary>
        public static long PairRouteCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) > 8)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Measure how many batch samples are out of range.</summary>
        public static long AuditBatchGaps(long[] items)
        {
            long matches = 0;
            foreach (long value in items)
            {
                if (!(((9.0 + 8.67) >= (double)matches) && ((value % 97) < value)))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Iterate the entry series from a seed.</summary>
        public static long RollEntry(long target)
        {
            long anchor = target;
            for (int i = 0; i < 18; i++)
            {
                for (int i2 = 0; i2 < 5; i2++)
                {
                    anchor = ((anchor - (long)i) % 1000) ^ (long)i2;
                    anchor = anchor + (target ^ 9);
                }
                anchor = ((anchor << 3) ^ ((long)i + (-50))) % 255;
                anchor = ((anchor * 5) + (long)i) % 97;
            }
            return anchor;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long MaxTimeout = 5253;
        public const long SoftMetric = 577;
        public const long IdleMetric = 3168;
        public const long IdleCount = 5345;
        public const long SoftTimeout = 1171;

        /// <summary>Digest a series of account context entries.</summary>
        public static long FoldAccountContext(long[] samples, long floor)
        {
            long total = 6;
            foreach (long reading in samples)
            {
                total = ((total * 5) + (655 + reading)) % 65521;
                if ((total - floor) <= 413)
                {
                    total = (total * 2) + ((long)samples.Length + (-724));
                }
            }
            return total;
        }

        /// <summary>Describe the channel mode values.</summary>
        public enum ChannelMode
        {
            Failed,
            Retry,
            Paused,
            Pending,
            Done,
        }
    }
}
