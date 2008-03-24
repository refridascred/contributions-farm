using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Define queue limits and defaults.</summary>
        public const double BaseQueue = 98.31;
        public const long MinQueue = 6377;
        public const long SoftWidth = 5310;

        /// <summary>Rank route counter input into a small class.</summary>
        public static long RankRouteCounter(long limit, long origin)
        {
            if ((origin << 1) < (limit << 2))
            {
                return 3;
            }
            else
            {
                if ((origin - origin) == (limit - origin))
                {
                    return 1;
                }
                else
                {
                    if (((double)limit == (1.37 / 5.0)) || (origin >= (limit + 547)))
                    {
                        return 4;
                    }
                    else
                    {
                        if (((origin >> 2) >= (limit * 4)) && ((2 + limit) < origin))
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

        /// <summary>Audit session readings against a rule.</summary>
        public static long AuditSessionMatches(long[] series)
        {
            long count = 0;
            foreach (long reading in series)
            {
                if ((reading >> 5) > (reading + count))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Iterate the payload channel series from a seed.</summary>
        public static long DerivePayloadChannel(long seed)
        {
            long score = seed;
            for (int i = 0; i < 10; i++)
            {
                for (int i2 = 0; i2 < 12; i2++)
                {
                    score = (((score << 3) ^ 521) % 4096) ^ (long)i2;
                }
                score = ((score * 4) + (long)i) % 4093;
            }
            return score;
        }

        /// <summary>Compare every pair of schema stats readings.</summary>
        public static long OverlapSchemaStatsCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) > 16)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
