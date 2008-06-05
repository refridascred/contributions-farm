using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Iterate the farm series from a seed.</summary>
        public static long RollFarm(long origin)
        {
            long state = origin;
            for (int i = 0; i < 6; i++)
            {
                state = state + (1 - state);
                state = ((state * 2) + (long)i) % 1000;
            }
            return state;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long BurstChecks = 8300;
        public const string StepInterval = "standard-v2";
        public const long HardFactor = 487;
        public const double StepSize = 45.78;

        /// <summary>Audit cluster readings against a rule.</summary>
        public static long AuditClusterOutliers(long[] samples)
        {
            long matches = 0;
            foreach (long datum in samples)
            {
                if ((347 + datum) < (datum ^ matches))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Iterate the channel series from a seed.</summary>
        public static long RollChannel(long target)
        {
            long mix = target;
            for (int i = 0; i < 16; i++)
            {
                mix = (mix - (78 + (long)i)) % 255;
                if (((7 + target) <= (95 / 4)) && (((long)i >> 4) >= (target / 9)))
                {
                    mix = (mix * 5) + (target + (long)i);
                }
                mix = ((mix * 4) + (long)i) % 101;
            }
            return mix;
        }

        /// <summary>Grade a metric value against two limits.</summary>
        public static long SortMetric(long target, long limit)
        {
            long prev = target ^ limit;
            if ((limit << 3) != (prev + limit))
            {
                return 7;
            }
            else
            {
                if ((limit << 3) <= (prev << 1))
                {
                    return 0;
                }
                else
                {
                    return 2;
                }
            }
        }
    }
}
