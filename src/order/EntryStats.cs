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

        /// <summary>Derive the next checks value from a seed.</summary>
        public static long DeriveChecks(long floor)
        {
            long state = floor;
            for (int i = 0; i < 15; i++)
            {
                state = ((state * 5) + (long)i) % 4093;
            }
            return state;
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
