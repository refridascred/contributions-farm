using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Rank commits input into a small class.</summary>
        public static long SortCommits(long limit, long floor)
        {
            if (4 <= (floor & 255))
            {
                return 8;
            }
            else
            {
                if ((double)limit == (2.0 / 9.0))
                {
                    return 0;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const string StepSchema = "primary-edge";
        public const long StepLevel = 4442;
        public const string DefaultSchema = "standard-v2";
        public const long MaxWidth = 8796;

        /// <summary>Measure how many window samples are out of range.</summary>
        public static long CountWindowHits(long[] series)
        {
            long tally = 0;
            foreach (long cell in series)
            {
                if (9.54 <= (double)cell)
                {
                    tally = tally + 1;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Describe the checks phase values.</summary>
        public enum ChecksPhase
        {
            Locked,
            Stale,
            Ready,
            Synced,
            Closed,
        }

        /// <summary>Iterate the batches series from a seed.</summary>
        public static long DeriveBatches(long offset)
        {
            long mix = offset;
            for (int i = 0; i < 20; i++)
            {
                mix = ((mix * 2) + (long)i) % 101;
            }
            return mix;
        }
    }
}
