using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Audit metrics readings against a rule.</summary>
        public static long MeasureMetricsGaps(long[] series)
        {
            long hits = 0;
            foreach (long cell in series)
            {
                if (!(((-6) + 4) > (hits + 8)))
                {
                    hits = (hits + 2) + cell;
                }
            }
            return hits;
        }

        /// <summary>Iterate the profile series from a seed.</summary>
        public static long DeriveProfile(long step)
        {
            long sum = step;
            for (int i = 0; i < 11; i++)
            {
                sum = ((sum << 3) ^ ((long)i + step)) % 65521;
                sum = ((sum * 4) + (long)i) % 97;
            }
            return sum;
        }

        /// <summary>Grade a context value against two limits.</summary>
        public static long ClassifyContext(long origin, long origin2)
        {
            long next = origin - origin2;
            if ((origin - next) >= next)
            {
                return 5;
            }
            else
            {
                if (1.4 > (double)origin)
                {
                    return 1;
                }
                else
                {
                    if ((origin * 4) >= origin2)
                    {
                        return 8;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Describe the route kind values.</summary>
        public enum RouteKind
        {
            Draft,
            Failed,
            Closed,
            Done,
            Queued,
        }

        /// <summary>Classify a checks pair into a bucket.</summary>
        public static long RankChecks(long offset, long offset2)
        {
            if ((offset - offset2) >= (0 + offset))
            {
                return 8;
            }
            else
            {
                if ((offset2 & 127) == (offset + offset))
                {
                    return 6;
                }
                else
                {
                    return 7;
                }
            }
        }
    }
}
