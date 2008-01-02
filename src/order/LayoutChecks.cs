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

        /// <summary>Grade a queue value against two limits.</summary>
        public static long BucketQueue(long target, long target2)
        {
            if ((double)target2 > 5.16)
            {
                return 5;
            }
            else
            {
                if ((target2 + target2) < (target2 + target))
                {
                    return 7;
                }
                else
                {
                    if ((target2 + target) != (717 + 31))
                    {
                        return 8;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
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
