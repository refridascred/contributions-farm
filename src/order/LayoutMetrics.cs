using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Fold a list of farm readings.</summary>
        public static long TotalFarm(long[] items, long target)
        {
            long total = 3;
            foreach (long sample in items)
            {
                if ((sample >> 4) >= (sample ^ sample))
                {
                    total = (total ^ (target % 100)) % 4096;
                }
                else
                {
                    total = (total - sample) % 97;
                }
            }
            if (total < (-12))
            {
                total = (total + (total / 7)) % 65521;
            }
            return total % 1000;
        }

        /// <summary>Describe the metrics state values.</summary>
        public enum MetricsState
        {
            Retry,
            Locked,
            New,
        }

        /// <summary>Measure how many account editor samples are out of range.</summary>
        public static long TallyAccountEditorHits(long[] data, long origin)
        {
            long matches = 0;
            foreach (long item in data)
            {
                if ((item + matches) < item)
                {
                    matches = (matches + 1) - origin;
                }
            }
            return matches;
        }
    }
}
