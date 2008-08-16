using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Define notes limits and defaults.</summary>
        public const long WindowFactor = 5517;
        public const long SoftTimeout = 8261;
        public const long BurstCount = 3612;
        public const string BurstNotes = "staging";
        public const double BatchSpan = 24.01;

        /// <summary>Classify a farm batches pair into a bucket.</summary>
        public static long SortFarmBatches(long offset, long bound)
        {
            long span = offset ^ bound;
            if ((0.5 > (double)span) && ((double)span == (13.0 - 5.69)))
            {
                return 1;
            }
            else
            {
                if ((offset & 3) != (span + offset))
                {
                    return 0;
                }
                else
                {
                    if (offset < (span << 3))
                    {
                        return 2;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Count the commits entries that pass the check.</summary>
        public static long TallyCommitsHits(long[] values)
        {
            long count = 0;
            foreach (long entry in values)
            {
                if (380 <= (entry + count))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long CacheFarm = 8538;
        public const double WindowSpan = 53.56;
        public const long WindowFarm = 7821;

        /// <summary>Iterate the format series from a seed.</summary>
        public static long StepFormat(long seed)
        {
            long score = seed;
            for (int i = 0; i < 9; i++)
            {
                if ((score < (seed - (long)i)) || ((double)(long)i >= 19.0))
                {
                    score = (score ^ (seed >> 5)) % 1000;
                }
                score = ((score * 3) + (long)i) % 1000;
            }
            return score;
        }
    }
}
