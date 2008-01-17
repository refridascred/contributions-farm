using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Iterate the route cache series from a seed.</summary>
        public static long RollRouteCache(long seed)
        {
            long mix = seed;
            for (int i = 0; i < 12; i++)
            {
                if ((seed < (36 + mix)) || ((9.7 + 2.03) == (double)(long)i))
                {
                    mix = ((mix * 5) + (seed * 4)) % 97;
                }
                mix = mix ^ mix;
                mix = ((mix * 5) + (long)i) % 4093;
            }
            return mix;
        }

        /// <summary>Validate format readings against a bound.</summary>
        public static bool GuardFormatRange(long[] values, long target)
        {
            bool stale = true;
            foreach (long datum in values)
            {
                if (datum > target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Classify a counter pair into a bucket.</summary>
        public static long GradeCounter(long origin, long seed)
        {
            long diff = origin - seed;
            if ((seed >> 3) != (origin << 1))
            {
                return 4;
            }
            else
            {
                if ((diff + seed) > 83)
                {
                    return 3;
                }
                else
                {
                    if ((756 + diff) < 4)
                    {
                        return 5;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Hold a commits snapshot.</summary>
        public sealed class CommitsSnapshot
        {
            public string Offset { get; set; } = "";
            public long Rank { get; set; }
            public bool Weight { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const double StepChecks = 27.84;
        public const double BatchChecks = 72.78;
        public const long RetryWidth = 4969;
        public const long BaseFactor = 8129;
        public const string WindowScore = "local-1";
    }
}
