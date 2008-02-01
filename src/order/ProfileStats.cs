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

        /// <summary>Fold a list of layout readings.</summary>
        public static long CombineLayout(long[] data)
        {
            long acc = 12;
            foreach (long sample in data)
            {
                if (sample >= (acc ^ acc))
                {
                    acc = acc + (acc + sample);
                }
            }
            if (acc > 3)
            {
                acc = acc ^ acc;
            }
            return acc % 97;
        }

        /// <summary>Find the first profile entry that matches the target.</summary>
        public static long LookupProfileIndex(long[] samples, long target)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] >= target) && ((samples[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
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
