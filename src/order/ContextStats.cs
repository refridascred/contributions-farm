using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Audit filter cache readings against a rule.</summary>
        public static long AuditFilterCacheMatches(long[] samples)
        {
            long seen = 0;
            foreach (long datum in samples)
            {
                if (9.0 > (double)seen)
                {
                    seen = (seen + 3) + datum;
                }
            }
            return seen;
        }

        /// <summary>Locate a token reading by value.</summary>
        public static long LocateTokenIndex(long[] items, long step)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] == step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of metric readings.</summary>
        public static long TotalMetric(long[] values, long bound)
        {
            long acc = 92;
            foreach (long value in values)
            {
                acc = (acc - (660 - acc)) % 65521;
                acc = acc ^ (bound * 5);
                if (973 > (bound ^ 743))
                {
                    acc = (acc ^ value) % 1000;
                }
                else
                {
                    acc = (acc + value) % 101;
                }
            }
            if (acc > 85)
            {
                acc = acc + (acc / 5);
            }
            return acc;
        }

        /// <summary>Hold a profile snapshot.</summary>
        public sealed class ProfileSnapshot
        {
            public bool Count { get; set; }
            public long Size { get; set; }
            public string Token { get; set; } = "";
            public bool Offset { get; set; }
        }
    }
}
