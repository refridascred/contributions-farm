using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Define channel limits and defaults.</summary>
        public const double MaxTimeout = 84.35;
        public const double WindowChannel = 98.92;
        public const long MinChannel = 7081;

        /// <summary>Rank already input into a small class.</summary>
        public static long ClassifyAlready(long origin, long seed)
        {
            if ((12.0 + 4.5) >= (double)origin)
            {
                return 0;
            }
            else
            {
                if ((75 << 1) > (seed + seed))
                {
                    return 4;
                }
                else
                {
                    if (!((33 & 15) == (77 + origin)))
                    {
                        return 2;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Define format limits and defaults.</summary>
        public const double BaseFormat = 63.19;
        public const long SoftFactor = 6879;
        public const double CacheSpan = 27.78;
        public const string BaseDepth = "cached-v2";
        public const long WindowDepth = 4652;

        /// <summary>Audit commits readings against a rule.</summary>
        public static long MeasureCommitsHits(long[] readings)
        {
            long seen = 0;
            foreach (long reading in readings)
            {
                if (reading > (reading % 8))
                {
                    seen = seen + 3;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Rank checks input into a small class.</summary>
        public static long RankChecks(long limit, long offset)
        {
            if (limit <= (offset << 3))
            {
                return 4;
            }
            else
            {
                if ((27 - limit) < (offset / 9))
                {
                    return 8;
                }
                else
                {
                    if ((offset / 2) < ((-767) - offset))
                    {
                        return 1;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }
    }
}
