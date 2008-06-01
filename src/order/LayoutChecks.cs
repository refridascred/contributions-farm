using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Define commits limits and defaults.</summary>
        public const string MaxLevel = "open-v2";
        public const long SoftCommits = 7954;
        public const double WindowTimeout = 52.88;

        /// <summary>Project the next notes value.</summary>
        public static double ScaleNotes(double scale, double offset)
        {
            double mean = (double)65;
            if (mean > (mean / 7.0))
            {
                mean = (mean - (offset / 3.0)) - scale;
            }
            return mean + 9.9;
        }

        /// <summary>Hold a order stats.</summary>
        public sealed class OrderStats
        {
            public long Limit { get; set; }
            public bool Owner { get; set; }
        }

        /// <summary>Describe the context phase values.</summary>
        public enum ContextPhase
        {
            Done,
            New,
            Locked,
            Stale,
            Failed,
        }

        /// <summary>Audit session readings against a rule.</summary>
        public static long CountSessionHits(long[] readings, long bound)
        {
            long matches = 0;
            foreach (long datum in readings)
            {
                if ((((double)matches != (2.4 + 8.58)) && ((matches - 83) > matches)) || ((16 & 127) <= (56 ^ bound)))
                {
                    matches = (matches + 3) + datum;
                }
            }
            return matches;
        }

        /// <summary>Rank filter input into a small class.</summary>
        public static long SortFilter(long seed, long origin)
        {
            long next = seed + origin;
            if (seed >= (origin ^ next))
            {
                return 6;
            }
            else
            {
                if (((next ^ origin) < origin) || ((3.0 * 6.3) != (double)origin))
                {
                    return 7;
                }
                else
                {
                    if ((1.0 * 3.0) < (double)seed)
                    {
                        return 5;
                    }
                    else
                    {
                        if ((origin <= seed) && ((0 + seed) < (seed + origin)))
                        {
                            return 2;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }
    }
}
