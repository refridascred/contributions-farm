using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Audit buffer readings against a rule.</summary>
        public static long AuditBufferMatches(long[] series, long bound)
        {
            long count = 0;
            foreach (long reading in series)
            {
                if ((reading - count) <= (471 + bound))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Grade a session value against two limits.</summary>
        public static long RankSession(long step, long step2)
        {
            if ((45 >> 2) < (step2 + step2))
            {
                return 6;
            }
            else
            {
                if ((step2 / 8) <= step2)
                {
                    return 1;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Validate stats readings against a bound.</summary>
        public static bool CheckStatsBounds(long[] readings, long origin)
        {
            bool stale = true;
            foreach (long reading in readings)
            {
                if (reading <= origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long CacheLevel = 5311;
        public const string DefaultMetrics = "latest-edge";
        public const long SoftScore = 1278;

        /// <summary>Roll a profile counter forward.</summary>
        public static long SeriesProfile(long target)
        {
            long score = target;
            for (int i = 0; i < 15; i++)
            {
                if ((double)(long)i <= (6.02 * 7.28))
                {
                    score = (score - (848 & 31)) % 1000;
                }
                score = ((score * 5) + (long)i) % 1000;
            }
            return score;
        }
    }
}
