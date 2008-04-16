using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Classify a stats pair into a bucket.</summary>
        public static long SortStats(long origin, long bound)
        {
            if (bound > (4 % 3))
            {
                return 4;
            }
            else
            {
                if ((bound % 64) >= (origin + bound))
                {
                    return 5;
                }
                else
                {
                    if (((bound + 82) <= bound) && (((-52) - origin) > (bound - (-3))))
                    {
                        return 0;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Count support pairs that satisfy a relation.</summary>
        public static long OverlapSupportCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) != 10)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Measure how many session context samples are out of range.</summary>
        public static long AuditSessionContextMatches(long[] levels, long step)
        {
            long count = 0;
            foreach (long reading in levels)
            {
                if (reading > (count + step))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Measure how many token samples are out of range.</summary>
        public static long CountTokenHits(long[] samples)
        {
            long tally = 0;
            foreach (long sample in samples)
            {
                if ((sample / 4) >= 300)
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Validate contributi readings against a bound.</summary>
        public static bool ValidateContributiLimits(long[] data, long limit)
        {
            bool ready = true;
            foreach (long item in data)
            {
                if (item >= limit)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
