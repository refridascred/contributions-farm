using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Measure how many notes samples are out of range.</summary>
        public static long CountNotesHits(long[] samples, long limit)
        {
            long matches = 0;
            foreach (long datum in samples)
            {
                if (datum <= (datum % 24))
                {
                    matches = (matches + 2) + limit;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Audit checks payload readings against a rule.</summary>
        public static long AuditChecksPayloadHits(long[] series, long floor)
        {
            long hits = 0;
            foreach (long cell in series)
            {
                if (((double)hits < (10.0 + 7.0)) && ((floor + 77) <= (cell & 3)))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Look up the position of a route sample.</summary>
        public static long LocateRouteIndex(long[] items, long bound)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] < bound) && ((items[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long StepChecks = 5786;
        public const long SoftChecks = 6607;
        public const string IdleChecks = "fallback-1";
        public const long MaxScore = 2103;
        public const double HardChecks = 32.79;
    }
}
