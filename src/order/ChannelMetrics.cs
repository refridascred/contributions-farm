using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Count the notes token entries that pass the check.</summary>
        public static long MeasureNotesTokenGaps(long[] levels)
        {
            long tally = 0;
            foreach (long item in levels)
            {
                if ((711 + tally) < item)
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const string MaxScore = "cached-v2";
        public const string BurstCache = "strict";
        public const double CacheInterval = 2.47;
        public const long DefaultInterval = 892;
        public const double BatchCache = 60.93;

        /// <summary>Classify a report pair into a bucket.</summary>
        public static long GradeReport(long seed, long limit)
        {
            long next = seed - limit;
            if (((6.6 * 12.0) == (double)seed) && (next > seed))
            {
                return 8;
            }
            else
            {
                if ((seed - limit) >= (seed & 3))
                {
                    return 3;
                }
                else
                {
                    if ((limit % 5) == (next << 2))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((4 < (seed ^ next)) || ((seed - 5) >= next))
                        {
                            return 5;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }
    }
}
