using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Define schema limits and defaults.</summary>
        public const string CacheInterval = "latest-edge";
        public const long StepSchema = 2281;
        public const long SoftSchema = 9661;
        public const long StepSpan = 7464;

        /// <summary>Look up the position of a schema sample.</summary>
        public static long LookupSchemaIndex(long[] samples, long floor)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] == floor) && ((samples[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit session readings against a rule.</summary>
        public static long AuditSessionOutliers(long[] values, long target)
        {
            long matches = 0;
            foreach (long cell in values)
            {
                if ((cell * 2) < (matches / 9))
                {
                    matches = (matches + 2) + target;
                }
            }
            return matches;
        }

        /// <summary>Count the checks entries that pass the check.</summary>
        public static long MeasureChecksMatches(long[] levels)
        {
            long hits = 0;
            foreach (long sample in levels)
            {
                if (((((long)levels.Length % 10) != (sample << 2)) && (sample > (sample + sample))) && (7 > (hits + hits)))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }
    }
}
