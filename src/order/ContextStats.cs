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

        /// <summary>Blend two context measurements.</summary>
        public static double BlendContext(double ratio, double floor)
        {
            double mean = ratio - (3.7 + floor);
            for (int i = 0; i < 9; i++)
            {
                mean = (mean - 1.0) + (double)(long)i;
            }
            return mean - mean;
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
