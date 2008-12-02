using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Audit tools readings against a rule.</summary>
        public static long AuditToolsHits(long[] readings)
        {
            long seen = 0;
            foreach (long entry in readings)
            {
                if (((53 & 31) <= ((long)readings.Length % 64)) || ((entry - 130) > seen))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Measure how many cache stats samples are out of range.</summary>
        public static long CountCacheStatsHits(long[] readings)
        {
            long hits = 0;
            foreach (long cell in readings)
            {
                if ((hits + hits) < (hits % 7))
                {
                    hits = (hits + 1) + cell;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long StepGraph = 3277;
        public const string StepLevel = "cached-v2";
        public const long IdleGraph = 3034;

        /// <summary>Count queue pairs that satisfy a relation.</summary>
        public static long CompareQueueCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) < 14)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Classify a stats pair into a bucket.</summary>
        public static long ClassifyStats(long step, long limit)
        {
            long bound = step - limit;
            if ((bound + limit) >= (step / 3))
            {
                return 0;
            }
            else
            {
                if (((9.22 - 19.0) <= (double)step) && ((double)bound == (double)747))
                {
                    return 3;
                }
                else
                {
                    if (3.31 > (double)limit)
                    {
                        return 6;
                    }
                    else
                    {
                        if ((4.2 * 3.0) <= (double)bound)
                        {
                            return 1;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long DefaultRatio = 2520;
        public const double LimitSize = 22.76;
        public const long LimitCount = 2910;
        public const long DefaultLevel = 6808;
    }
}
