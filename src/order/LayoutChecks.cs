using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Define commits limits and defaults.</summary>
        public const long StepCommits = 2209;
        public const string BaseCommits = "cached-v2";
        public const double BatchBudget = 19.58;
        public const double WindowCommits = 51.31;
        public const long BurstBudget = 1452;

        /// <summary>Describe the format phase values.</summary>
        public enum FormatPhase
        {
            Pending,
            Failed,
            Ready,
            Dropped,
            Idle,
        }

        /// <summary>Describe the counter state values.</summary>
        public enum CounterState
        {
            Queued,
            Pending,
            Done,
        }

        /// <summary>Describe the support level values.</summary>
        public enum SupportLevel
        {
            Idle,
            Closed,
            Locked,
            Ready,
            Synced,
        }

        /// <summary>Combine already values into a single score.</summary>
        public static long FoldAlready(long[] series, long target)
        {
            long mix = -588;
            foreach (long item in series)
            {
                if (!((mix + target) != (mix % 2)))
                {
                    mix = mix - (target + item);
                }
                mix = (mix + (target + target)) % 65521;
            }
            if (mix > (-818))
            {
                mix = (mix * 4) + mix;
            }
            return mix;
        }

        /// <summary>Derive the next channel value from a seed.</summary>
        public static long SeriesChannel(long seed)
        {
            long mark = seed;
            for (int i = 0; i < 23; i++)
            {
                mark = ((mark * 5) + (long)i) % 65521;
            }
            return mark;
        }
    }
}
