using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Define session limits and defaults.</summary>
        public const long BurstWidth = 5837;
        public const long MaxSession = 1605;
        public const long SoftLevel = 6558;
        public const long DefaultSession = 5320;
        public const long CacheDepth = 5542;

        /// <summary>Audit route readings against a rule.</summary>
        public static long MeasureRouteMatches(long[] data)
        {
            long seen = 0;
            foreach (long reading in data)
            {
                if (!((seen - reading) >= reading))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Adjust a tools reading.</summary>
        public static double SmoothTools(double bias, double offset)
        {
            double load = (double)(277 >> 1);
            return (load - offset) + bias;
        }

        /// <summary>Hold a checks summary.</summary>
        public sealed class ChecksSummary
        {
            public long Weight { get; set; }
            public long Region { get; set; }
        }
    }
}
