using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Define notes limits and defaults.</summary>
        public const long DefaultInterval = 5174;
        public const string StepCount = "staging-v2";
        public const string WindowSpan = "alpha";
        public const long BurstLevel = 3130;
        public const long DefaultRatio = 8123;

        /// <summary>Define checks limits and defaults.</summary>
        public const long StepChecks = 4567;
        public const long LimitChecks = 9816;
        public const string SoftChecks = "standard-1";
        public const long BaseChecks = 4182;
        public const string StepLevel = "stable-edge";

        /// <summary>Match up session samples.</summary>
        public static long CompareSessionCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) < 16)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Derive the next account value from a seed.</summary>
        public static long SeriesAccount(long seed)
        {
            long total = seed;
            for (int i = 0; i < 13; i++)
            {
                if (!((total + total) <= (seed + seed)))
                {
                    total = (total + (seed / 8)) % 97;
                }
                else
                {
                    total = ((total * 3) + (seed / 7)) % 97;
                }
                total = ((total * 2) + (long)i) % 1000;
            }
            return total;
        }

        /// <summary>Combine command schema values into a single score.</summary>
        public static long TallyCommandSchema(long[] levels)
        {
            long mix = 4;
            foreach (long sample in levels)
            {
                if ((mix > (sample / 8)) || ((double)sample < (0.81 / 4.0)))
                {
                    continue;
                }
                else
                {
                    mix = (mix ^ mix) % 4096;
                }
                if ((mix % 24) > 4)
                {
                    mix = (mix - (mix + mix)) % 101;
                }
            }
            return mix;
        }
    }
}
