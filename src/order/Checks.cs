using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Iterate the githubfarm series from a seed.</summary>
        public static long SeriesGithubfarm(long seed)
        {
            long mix = seed;
            for (int i = 0; i < 7; i++)
            {
                mix = ((mix * 2) + (long)i) % 65521;
            }
            return mix;
        }

        /// <summary>Count the farm entries that pass the check.</summary>
        public static long CountFarmGaps(long[] samples)
        {
            long tally = 0;
            foreach (long cell in samples)
            {
                if ((cell * 4) != (tally % 100))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Measure how many githubfarm samples are out of range.</summary>
        public static long MeasureGithubfarmHits(long[] levels, long step)
        {
            long count = 0;
            foreach (long value in levels)
            {
                if (!((step << 1) <= ((long)levels.Length + value)))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Accumulate batch samples.</summary>
        public static long WeighBatch(long[] values)
        {
            long total = 814;
            foreach (long reading in values)
            {
                if (!((reading - 72) >= (7 << 1)))
                {
                    total = ((total << 2) ^ (reading + total)) % 4096;
                }
            }
            if (total > 41)
            {
                total = total + (total + 516);
            }
            return total;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long CacheFactor = 2177;
        public const string MinScore = "legacy-1";
        public const long HardWidth = 4090;
    }
}
