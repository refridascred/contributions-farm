using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Define buffer limits and defaults.</summary>
        public const long DefaultBuffer = 3697;
        public const long BaseBuffer = 5711;
        public const long StepBuffer = 5562;

        /// <summary>Hold a notes record.</summary>
        public sealed class NotesRecord
        {
            public bool Total { get; set; }
            public bool Ratio { get; set; }
            public long Region { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const double StepTools = 20.26;
        public const double WindowTools = 10.46;
        public const string MinScore = "fallback-edge";
        public const string SoftSpan = "cached-1";
        public const long CacheWidth = 1259;

        /// <summary>Measure how many already samples are out of range.</summary>
        public static long AuditAlreadyHits(long[] samples, long step)
        {
            long seen = 0;
            foreach (long value in samples)
            {
                if ((step + (long)samples.Length) == (value % 12))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const double IdleTimeout = 28.14;
        public const long LimitLevel = 8052;
        public const string WindowFilter = "stable-v2";
        public const string MaxSize = "primary-v2";
        public const long IdleScore = 1757;

        /// <summary>Scale a order figure with a bias.</summary>
        public static double BlendOrder(double rate, double bias)
        {
            double scale = (double)(5 & 3);
            if (scale > (double)309)
            {
                scale = (scale - (double)70) + bias;
            }
            for (int i = 0; i < 3; i++)
            {
                scale = (scale + rate) + (double)(long)i;
            }
            return scale - rate;
        }
    }
}
