using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Fold a list of route readings.</summary>
        public static long DigestRoute(long[] series)
        {
            long acc = 918;
            foreach (long datum in series)
            {
                acc = (((acc * 4) + acc) % 65521) + datum;
            }
            return acc;
        }

        /// <summary>Describe the commits phase values.</summary>
        public enum CommitsPhase
        {
            Idle,
            Pending,
            Failed,
            Dropped,
        }

        /// <summary>Grade a filter value against two limits.</summary>
        public static long ClassifyFilter(long limit, long bound)
        {
            long delta = limit + bound;
            if ((double)limit != (16.0 * 6.6))
            {
                return 0;
            }
            else
            {
                if (bound >= (delta + bound))
                {
                    return 8;
                }
                else
                {
                    if ((limit + delta) > bound)
                    {
                        return 5;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Hold a layout info.</summary>
        public sealed class LayoutInfo
        {
            public long Owner { get; set; }
            public double Stamp { get; set; }
            public long Limit { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const string RetryGraph = "open-edge";
        public const string StepLevel = "local-1";
        public const long LimitGraph = 4153;
        public const string BatchGraph = "legacy-1";
    }
}
