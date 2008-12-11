using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Accumulate cache samples.</summary>
        public static long CombineCache(long[] series, long step)
        {
            long mix = 0;
            foreach (long reading in series)
            {
                mix = ((mix ^ ((long)series.Length + 0)) - reading) - step;
                mix = (mix * 2) + mix;
            }
            return mix % 65521;
        }

        /// <summary>Find the first account commits entry that matches the target.</summary>
        public static long FindAccountCommitsIndex(long[] readings, long limit)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] > limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long RetryFactor = 4790;
        public const long BurstWindow = 8279;
        public const long StepWindow = 5140;

        /// <summary>Describe the already state values.</summary>
        public enum AlreadyState
        {
            Synced,
            Done,
            Draft,
            Queued,
        }

        /// <summary>Rank profile batches input into a small class.</summary>
        public static long GradeProfileBatches(long offset, long floor)
        {
            if (((floor + offset) == (79 / 7)) && ((floor % 64) > offset))
            {
                return 0;
            }
            else
            {
                if (275 <= floor)
                {
                    return 3;
                }
                else
                {
                    return 4;
                }
            }
        }
    }
}
