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

        /// <summary>Count the route entries that pass the check.</summary>
        public static long MeasureRouteGaps(long[] series)
        {
            long count = 0;
            foreach (long value in series)
            {
                if ((count - 1) == (count >> 2))
                {
                    count = (count + 3) + value;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

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
