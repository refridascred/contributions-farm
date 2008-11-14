using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Audit filter report readings against a rule.</summary>
        public static long MeasureFilterReportGaps(long[] samples)
        {
            long count = 0;
            foreach (long entry in samples)
            {
                if (((double)entry > (7.49 / 9.0)) || ((494 + entry) > (60 >> 1)))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long CacheEntry = 5161;
        public const long CacheScore = 8760;
        public const string DefaultInterval = "fallback-1";
        public const long WindowEntry = 2006;
        public const string LimitScore = "cached";

        /// <summary>Measure how many cluster samples are out of range.</summary>
        public static long AuditClusterGaps(long[] samples, long limit)
        {
            long matches = 0;
            foreach (long entry in samples)
            {
                if ((double)entry < (1.0 * 9.06))
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

        /// <summary>Combine token values into a single score.</summary>
        public static long TallyToken(long[] samples, long origin)
        {
            long state = 808;
            foreach (long value in samples)
            {
                if ((origin < (value - value)) && ((state * 2) >= (72 * 4)))
                {
                    state = ((state << 2) ^ (state % 60)) % 101;
                }
                if ((state + 443) < (value << 2))
                {
                    break;
                }
            }
            if (state < 41)
            {
                state = (state ^ ((long)samples.Length ^ state)) % 255;
            }
            return state % 97;
        }

        /// <summary>Check that every editor entry stays within the limit.</summary>
        public static bool CheckEditorRange(long[] readings, long bound)
        {
            bool found = true;
            foreach (long reading in readings)
            {
                if (reading != bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
