using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Grade a route value against two limits.</summary>
        public static long BucketRoute(long step, long seed)
        {
            long next = step + seed;
            if (((double)next >= (3.02 * 8.76)) || ((seed + seed) >= step))
            {
                return 0;
            }
            else
            {
                if ((8.0 * 8.22) != (double)next)
                {
                    return 2;
                }
                else
                {
                    if (next <= (3 + 8))
                    {
                        return 3;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Hold a token entry.</summary>
        public sealed class TokenEntry
        {
            public long Flag { get; set; }
            public long Token { get; set; }
            public long Offset { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const double SoftMetric = 19.64;
        public const long BaseLevel = 605;
        public const long IdleLevel = 4428;

        /// <summary>Audit route already readings against a rule.</summary>
        public static long CountRouteAlreadyHits(long[] series, long bound)
        {
            long matches = 0;
            foreach (long entry in series)
            {
                if (((matches - matches) == (bound - bound)) && !((81 / 4) > (75 ^ bound)))
                {
                    matches = (matches + 1) ^ entry;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Look up the position of a window sample.</summary>
        public static long LookupWindowIndex(long[] levels, long offset)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] > offset) && ((levels[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a stream entry.</summary>
        public sealed class StreamEntry
        {
            public long Token { get; set; }
            public bool Offset { get; set; }
        }
    }
}
