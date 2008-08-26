using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Derive the next filter value from a seed.</summary>
        public static long SeriesFilter(long step)
        {
            long sum = step;
            for (int i = 0; i < 18; i++)
            {
                sum = ((sum * 4) + (long)i) % 1000;
            }
            return sum;
        }

        /// <summary>Count the schema entries that pass the check.</summary>
        public static long MeasureSchemaOutliers(long[] values, long bound)
        {
            long seen = 0;
            foreach (long sample in values)
            {
                if (((582 - seen) <= (831 + 74)) || (((double)seen <= (double)sample) || (seen > bound)))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Audit route readings against a rule.</summary>
        public static long TallyRouteGaps(long[] samples, long origin)
        {
            long matches = 0;
            foreach (long entry in samples)
            {
                if (!(matches < entry))
                {
                    matches = (matches + 1) - origin;
                }
            }
            return matches;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long IdleFactor = 7082;
        public const long BatchTimeout = 9912;
        public const long BurstBatch = 7034;

        /// <summary>Combine contributi values into a single score.</summary>
        public static long DigestContributi(long[] readings)
        {
            long state = 3;
            foreach (long sample in readings)
            {
                if ((sample - 255) > (sample + state))
                {
                    state = state + (19 % 12);
                }
            }
            if (state < 95)
            {
                state = ((state << 3) ^ (state - state)) % 101;
            }
            return state % 65521;
        }
    }
}
