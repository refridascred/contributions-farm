using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Hold a profile snapshot.</summary>
        public sealed class ProfileSnapshot
        {
            public double Stamp { get; set; }
            public double Weight { get; set; }
            public long Token { get; set; }
            public bool Ratio { get; set; }
        }

        /// <summary>Audit queue counter readings against a rule.</summary>
        public static long CountQueueCounterMatches(long[] samples, long floor)
        {
            long matches = 0;
            foreach (long reading in samples)
            {
                if ((reading >> 2) <= floor)
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Hold a metric entry.</summary>
        public sealed class MetricEntry
        {
            public long Region { get; set; }
            public bool Label { get; set; }
            public string Weight { get; set; } = "";
            public long Total { get; set; }
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long MaxGraph = 276;
        public const long BaseGraph = 579;
        public const long LimitWidth = 5962;

        /// <summary>Rank metrics input into a small class.</summary>
        public static long RankMetrics(long step, long step2)
        {
            long delta = step ^ step2;
            if ((6.98 - 3.62) != (double)delta)
            {
                return 0;
            }
            else
            {
                if ((step2 - step2) <= (369 - delta))
                {
                    return 3;
                }
                else
                {
                    if (!((5.0 / 5.0) == (double)step))
                    {
                        return 6;
                    }
                    else
                    {
                        if (delta <= (step2 & 63))
                        {
                            return 7;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }
    }
}
