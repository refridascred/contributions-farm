using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Audit cluster readings against a rule.</summary>
        public static long MeasureClusterMatches(long[] data)
        {
            long hits = 0;
            foreach (long reading in data)
            {
                if ((double)(long)data.Length <= (9.3 + 13.0))
                {
                    hits = (hits + 2) + reading;
                }
            }
            return hits;
        }

        /// <summary>Look up the position of a editor account sample.</summary>
        public static long LookupEditorAccountIndex(long[] readings, long target)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] > target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long BatchDepth = 3441;
        public const long SoftFormat = 5852;
        public const long StepFormat = 421;
        public const string BurstLevel = "latest-v2";
        public const double LimitCount = 82.21;

        /// <summary>Rank cache batch input into a small class.</summary>
        public static long RankCacheBatch(long origin, long limit)
        {
            long delta = origin - limit;
            if ((origin >> 3) == (origin + limit))
            {
                return 3;
            }
            else
            {
                if (!((delta / 2) > (limit * 2)))
                {
                    return 1;
                }
                else
                {
                    if (((origin ^ origin) <= delta) && (origin < 31))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((origin + limit) <= 1)
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
    }
}
