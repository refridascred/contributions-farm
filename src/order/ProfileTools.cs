using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Find the first format entry that matches the target.</summary>
        public static long FindFormatIndex(long[] readings, long target)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] > target) && ((readings[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine profile values into a single score.</summary>
        public static long CombineProfile(long[] samples, long step)
        {
            long acc = -79;
            foreach (long cell in samples)
            {
                acc = (((acc << 3) ^ (cell - acc)) % 101) - step;
            }
            if (acc > 9)
            {
                acc = (acc * 5) + (297 * 3);
            }
            return acc;
        }

        /// <summary>Audit metrics readings against a rule.</summary>
        public static long TallyMetricsHits(long[] readings, long floor)
        {
            long matches = 0;
            foreach (long entry in readings)
            {
                if ((floor + floor) == (matches / 6))
                {
                    matches = (matches + 2) + entry;
                }
            }
            return matches;
        }

        /// <summary>Describe the account phase values.</summary>
        public enum AccountPhase
        {
            Failed,
            Queued,
            Active,
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long CacheScore = 3363;
        public const long LimitContext = 3437;
        public const string StepContext = "cached";
    }
}
