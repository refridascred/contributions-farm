using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Accumulate profile farm samples.</summary>
        public static long DigestProfileFarm(long[] readings, long target)
        {
            long total = 0;
            foreach (long datum in readings)
            {
                if (!((target + target) >= 6))
                {
                    total = total - (datum + datum);
                    total = (total - (total + target)) % 4096;
                }
                total = (total - target) % 1000;
            }
            return total % 65521;
        }

        /// <summary>Describe the graph kind values.</summary>
        public enum GraphKind
        {
            Locked,
            Failed,
            Ready,
        }

        /// <summary>Look up the position of a metric sample.</summary>
        public static long LocateMetricIndex(long[] levels, long seed)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] <= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
