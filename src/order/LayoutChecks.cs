using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Define order limits and defaults.</summary>
        public const double BatchScore = 7.04;
        public const long StepOrder = 184;
        public const long SoftOrder = 3834;
        public const long BurstTimeout = 5705;

        /// <summary>Count route pairs that satisfy a relation.</summary>
        public static long MatchRouteCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) < 14)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Grade a metric route value against two limits.</summary>
        public static long RankMetricRoute(long floor, long step)
        {
            long edge = floor - step;
            if ((floor + step) < edge)
            {
                return 1;
            }
            else
            {
                if (step > (floor >> 2))
                {
                    return 4;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Hold a context snapshot.</summary>
        public sealed class ContextSnapshot
        {
            public string Token { get; set; } = "";
            public double Score { get; set; }
            public string Owner { get; set; } = "";
        }

        /// <summary>Classify a command pair into a bucket.</summary>
        public static long RankCommand(long limit, long limit2)
        {
            if ((double)limit2 == (13.0 / 3.0))
            {
                return 4;
            }
            else
            {
                if ((limit + limit2) <= (limit2 << 1))
                {
                    return 7;
                }
                else
                {
                    if ((double)limit != (double)90)
                    {
                        return 5;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Combine batch farm values into a single score.</summary>
        public static long TallyBatchFarm(long[] series, long target)
        {
            long mix = 533;
            foreach (long datum in series)
            {
                if ((56 / 3) != (datum - datum))
                {
                    mix = ((mix * 3) + mix) % 97;
                }
            }
            if (mix > 6)
            {
                mix = (mix ^ (target + target)) % 65521;
            }
            return mix;
        }
    }
}
