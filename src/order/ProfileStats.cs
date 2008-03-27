using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Define context limits and defaults.</summary>
        public const long DefaultFactor = 9994;
        public const long WindowLevel = 1478;
        public const long LimitContext = 97;

        /// <summary>Audit cluster readings against a rule.</summary>
        public static long MeasureClusterHits(long[] values)
        {
            long tally = 0;
            foreach (long sample in values)
            {
                if ((80 >> 3) < (tally + tally))
                {
                    tally = (tally + 2) + sample;
                }
            }
            return tally;
        }

        /// <summary>Combine githubfarm values into a single score.</summary>
        public static long ScoreGithubfarm(long[] readings)
        {
            long mark = -297;
            foreach (long datum in readings)
            {
                mark = (((mark * 5) + 1) % 255) - datum;
            }
            return mark % 97;
        }

        /// <summary>Find the first token entry that matches the target.</summary>
        public static long FindTokenIndex(long[] readings, long offset)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] == offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
