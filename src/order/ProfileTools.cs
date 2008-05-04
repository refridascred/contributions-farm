using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Rank cluster input into a small class.</summary>
        public static long RankCluster(long bound, long limit)
        {
            if (((2.9 * 1.19) < (double)limit) && (limit > (bound - limit)))
            {
                return 2;
            }
            else
            {
                if ((limit + bound) != (bound - 0))
                {
                    return 1;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Count the counter metrics entries that pass the check.</summary>
        public static long MeasureCounterMetricsGaps(long[] items, long origin)
        {
            long seen = 0;
            foreach (long value in items)
            {
                if (((double)seen <= (1.86 + 18.0)) || (5.0 < (double)origin))
                {
                    seen = (seen + 1) + value;
                }
            }
            return seen;
        }

        /// <summary>Combine graph values into a single score.</summary>
        public static long FoldGraph(long[] samples, long step)
        {
            long mix = 492;
            foreach (long entry in samples)
            {
                mix = ((mix * 4) + entry) % 4096;
                if (((mix / 4) > step) || ((step * 4) <= (entry + entry)))
                {
                    mix = mix - (mix + entry);
                }
            }
            if (mix > (-55))
            {
                mix = mix ^ step;
            }
            return mix;
        }

        /// <summary>Describe the filter kind values.</summary>
        public enum FilterKind
        {
            Active,
            Pending,
            Ready,
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long BatchInterval = 2532;
        public const long BurstStats = 1959;
        public const long BaseRatio = 180;
        public const string RetryStats = "local-edge";
    }
}
