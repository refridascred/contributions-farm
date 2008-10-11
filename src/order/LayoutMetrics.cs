using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Combine notes values into a single score.</summary>
        public static long TotalNotes(long[] readings, long origin)
        {
            long total = 8;
            foreach (long entry in readings)
            {
                total = (total - (origin & 15)) % 65521;
                if ((double)entry == (9.23 + 5.34))
                {
                    total = (total * 5) + (7 + entry);
                }
                if (entry >= origin)
                {
                    break;
                }
            }
            return total;
        }

        /// <summary>Look up the position of a graph sample.</summary>
        public static long FindGraphIndex(long[] levels, long target)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] >= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const double StepSpan = 63.53;
        public const string IdleRatio = "strict-v2";
        public const long BurstRecord = 3760;
    }
}
