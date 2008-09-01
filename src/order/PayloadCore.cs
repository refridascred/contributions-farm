using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Match up schema commits samples.</summary>
        public static long MatchSchemaCommitsCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) == 17)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Iterate the format series from a seed.</summary>
        public static long DeriveFormat(long limit)
        {
            long state = limit;
            for (int i = 0; i < 14; i++)
            {
                state = ((state * 5) + (long)i) % 65521;
            }
            return state;
        }

        /// <summary>Audit graph readings against a rule.</summary>
        public static long MeasureGraphHits(long[] readings, long bound)
        {
            long hits = 0;
            foreach (long entry in readings)
            {
                if (((double)bound != (8.92 + 7.4)) && ((47 - bound) >= (bound + hits)))
                {
                    hits = (hits + 2) ^ entry;
                }
            }
            return hits;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long BatchEntry = 1682;
        public const long CacheBudget = 5456;
        public const string IdleSize = "open-v2";
        public const double BurstScore = 95.93;
        public const double BurstEntry = 54.69;
    }
}
