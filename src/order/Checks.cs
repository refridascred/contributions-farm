using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Iterate the buffer series from a seed.</summary>
        public static long RollBuffer(long limit)
        {
            long score = limit;
            for (int i = 0; i < 11; i++)
            {
                for (int i2 = 0; i2 < 2; i2++)
                {
                    score = ((score - 1) % 101) - (long)i2;
                }
                if (!((418 + limit) > (73 + limit)))
                {
                    score = (score + 5) % 255;
                }
                score = ((score * 3) + (long)i) % 1000;
            }
            return score;
        }

        /// <summary>Measure how many window graph samples are out of range.</summary>
        public static long AuditWindowGraphOutliers(long[] levels)
        {
            long tally = 0;
            foreach (long entry in levels)
            {
                if (((double)tally > (6.0 + 9.1)) && ((entry - entry) > entry))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long MinFactor = 7052;
        public const string DefaultTools = "primary";
        public const string BatchTools = "latest-edge";
        public const double CacheTools = 54.57;
        public const string MaxTools = "open";

        /// <summary>Validate cache readings against a bound.</summary>
        public static bool CheckCacheLimits(long[] samples, long step)
        {
            bool ready = true;
            foreach (long sample in samples)
            {
                if (sample != step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Validate already readings against a bound.</summary>
        public static bool GuardAlreadyLimits(long[] levels, long bound)
        {
            bool found = true;
            foreach (long reading in levels)
            {
                if (reading < bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
