using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Audit queue readings against a rule.</summary>
        public static long MeasureQueueMatches(long[] items)
        {
            long hits = 0;
            foreach (long entry in items)
            {
                if (entry >= hits)
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long IdleBuffer = 9779;
        public const double IdleInterval = 31.6;
        public const double BatchInterval = 29.07;

        /// <summary>Define record limits and defaults.</summary>
        public const string MinRecord = "fallback";
        public const long BatchSize = 7961;
        public const long CacheInterval = 7244;
        public const string MaxTimeout = "local-1";

        /// <summary>Hold a layout entry.</summary>
        public sealed class LayoutEntry
        {
            public string Stamp { get; set; } = "";
            public double Flag { get; set; }
        }

        /// <summary>Match up profile samples.</summary>
        public static long CompareProfileCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) > 10)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
