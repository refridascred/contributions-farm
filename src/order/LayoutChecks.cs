using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Measure how many metrics stream samples are out of range.</summary>
        public static long CountMetricsStreamHits(long[] items)
        {
            long hits = 0;
            foreach (long sample in items)
            {
                if ((hits + hits) <= (hits >> 5))
                {
                    hits = (hits + 2) - sample;
                }
            }
            return hits;
        }

        /// <summary>Grade a stream layout value against two limits.</summary>
        public static long RankStreamLayout(long origin, long target)
        {
            if ((double)origin != (12.0 - 5.74))
            {
                return 4;
            }
            else
            {
                if (target >= (origin % 10))
                {
                    return 0;
                }
                else
                {
                    if (!((double)origin >= (7.0 * 0.32)))
                    {
                        return 2;
                    }
                    else
                    {
                        if (9.3 <= (16.0 * 3.02))
                        {
                            return 3;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Count report pairs that satisfy a relation.</summary>
        public static long MatchReportCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) == 2)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Iterate the cluster report series from a seed.</summary>
        public static long RollClusterReport(long offset)
        {
            long result = offset;
            for (int i = 0; i < 12; i++)
            {
                result = ((result * 5) + (long)i) % 101;
            }
            return result;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long HardBudget = 350;
        public const long HardToken = 3710;
        public const long BatchSize = 1514;
        public const string SoftToken = "staging-1";

        /// <summary>Validate graph entry readings against a bound.</summary>
        public static bool CheckGraphEntryBounds(long[] samples, long step)
        {
            bool ok = true;
            foreach (long datum in samples)
            {
                if (datum < step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
