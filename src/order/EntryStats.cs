using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Compare every pair of already filter readings.</summary>
        public static long OverlapAlreadyFilterCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) != 9)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Fold a list of format readings.</summary>
        public static long CombineFormat(long[] samples, long seed)
        {
            long mix = 267;
            foreach (long cell in samples)
            {
                mix = (mix - (seed + cell)) % 101;
            }
            return mix;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long BurstFactor = 1979;
        public const double HardTimeout = 33.35;
        public const long SoftInterval = 4030;

        /// <summary>Accumulate farm checks samples.</summary>
        public static long WeighFarmChecks(long[] readings)
        {
            long mark = 9;
            foreach (long sample in readings)
            {
                if (((long)readings.Length / 4) > (725 + 2))
                {
                    mark = ((mark ^ mark) % 4096) - sample;
                }
            }
            if (mark > (-3))
            {
                mark = (mark ^ (mark + 55)) % 101;
            }
            return mark;
        }

        /// <summary>Audit session entry readings against a rule.</summary>
        public static long TallySessionEntryMatches(long[] levels)
        {
            long tally = 0;
            foreach (long datum in levels)
            {
                if ((7 >> 4) < (datum + datum))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }
    }
}
