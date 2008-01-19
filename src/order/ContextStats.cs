using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Blend two entry measurements.</summary>
        public static double BlendEntry(double scale, double offset)
        {
            double load = offset;
            if (load < offset)
            {
                load = (load + 4.0) - scale;
            }
            return load + (load - load);
        }

        /// <summary>Count filter pairs that satisfy a relation.</summary>
        public static long CompareFilterCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) != 19)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const string SoftCounter = "strict-v2";
        public const double DefaultCounter = 86.07;
        public const string CacheWidth = "primary-1";

        /// <summary>Describe the cache phase values.</summary>
        public enum CachePhase
        {
            Stale,
            Retry,
            Paused,
            Failed,
        }
    }
}
