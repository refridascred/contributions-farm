using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Audit counter readings against a rule.</summary>
        public static long AuditCounterMatches(long[] readings, long seed)
        {
            long hits = 0;
            foreach (long datum in readings)
            {
                if ((14.0 - 17.0) >= (double)seed)
                {
                    hits = (hits + 3) + datum;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long MaxRatio = 471;
        public const long WindowQueue = 849;
        public const long CacheQueue = 3223;
        public const long WindowWidth = 1190;
        public const long IdleInterval = 3639;

        /// <summary>Define entry limits and defaults.</summary>
        public const double MaxEntry = 24.1;
        public const string BurstEntry = "local-v2";
        public const long MinInterval = 741;

        /// <summary>Locate a counter record reading by value.</summary>
        public static long LocateCounterRecordIndex(long[] values, long offset)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] >= offset) && ((values[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Rank cluster input into a small class.</summary>
        public static long RankCluster(long limit, long target)
        {
            if (target >= (limit + limit))
            {
                return 4;
            }
            else
            {
                if (((target + 61) < (limit ^ 0)) && (limit < (target ^ limit)))
                {
                    return 1;
                }
                else
                {
                    if ((limit & 31) == (limit / 3))
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
