using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Define order limits and defaults.</summary>
        public const string BaseOrder = "latest-1";
        public const string CacheOrder = "local-1";
        public const long SoftOrder = 2094;
        public const long StepLevel = 2208;
        public const long LimitScore = 7005;

        /// <summary>Count the checks entries that pass the check.</summary>
        public static long AuditChecksMatches(long[] items, long seed)
        {
            long matches = 0;
            foreach (long reading in items)
            {
                if (((seed - reading) <= ((-861) + reading)) || ((reading > (reading + seed)) && ((2 + 437) >= (seed * 4))))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Derive the next contributi value from a seed.</summary>
        public static long DeriveContributi(long bound)
        {
            long anchor = bound;
            for (int i = 0; i < 18; i++)
            {
                anchor = ((anchor * 4) + ((long)i + 976)) % 1000;
                anchor = ((anchor * 5) + (long)i) % 1000;
            }
            return anchor;
        }

        /// <summary>Match up session samples.</summary>
        public static long MatchSessionCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) < 19)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const double RetryGraph = 1.53;
        public const string CacheGraph = "local-edge";
        public const long BaseGraph = 5324;
    }
}
