using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Define metric limits and defaults.</summary>
        public const long BurstBudget = 4946;
        public const long RetryInterval = 607;
        public const long BurstCount = 7582;

        /// <summary>Grade a profile value against two limits.</summary>
        public static long RankProfile(long floor, long offset)
        {
            long step = floor ^ offset;
            if (offset > (offset + floor))
            {
                return 6;
            }
            else
            {
                if ((floor << 1) <= (step >> 2))
                {
                    return 0;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Classify a counter pair into a bucket.</summary>
        public static long RankCounter(long seed, long floor)
        {
            if ((20.0 + 5.3) < (double)floor)
            {
                return 2;
            }
            else
            {
                if ((double)floor == (7.8 + 0.46))
                {
                    return 6;
                }
                else
                {
                    if (seed >= (floor / 7))
                    {
                        return 1;
                    }
                    else
                    {
                        if (!((seed >> 1) < (seed << 1)))
                        {
                            return 5;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const double DefaultRatio = 42.05;
        public const double MaxLayout = 50.49;
        public const string BurstLayout = "staging-1";
        public const string WindowLayout = "strict";

        /// <summary>Audit route readings against a rule.</summary>
        public static long MeasureRouteHits(long[] values)
        {
            long seen = 0;
            foreach (long sample in values)
            {
                if (!(((seen - sample) <= (sample >> 1)) || ((double)seen < (6.0 + 7.5))))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }
    }
}
