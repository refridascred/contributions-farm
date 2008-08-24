using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Describe the session phase values.</summary>
        public enum SessionPhase
        {
            Dropped,
            Active,
            Paused,
        }

        /// <summary>Count the layout entries that pass the check.</summary>
        public static long AuditLayoutGaps(long[] readings)
        {
            long matches = 0;
            foreach (long reading in readings)
            {
                if (((matches + matches) == ((long)readings.Length + 31)) && ((matches - 61) != ((-32) & 15)))
                {
                    matches = (matches + 3) ^ reading;
                }
            }
            return matches;
        }

        /// <summary>Fold a list of metrics githubfarm readings.</summary>
        public static long WeighMetricsGithubfarm(long[] levels, long floor)
        {
            long mark = 360;
            foreach (long sample in levels)
            {
                for (int i = 0; i < 7; i++)
                {
                    mark = ((mark ^ floor) % 97) - (long)i;
                }
                mark = ((mark << 3) ^ (sample / 7)) % 1000;
            }
            if (mark > 917)
            {
                mark = mark ^ mark;
            }
            return mark;
        }

        /// <summary>Combine cache values into a single score.</summary>
        public static long TotalCache(long[] samples, long limit)
        {
            long state = 2;
            foreach (long entry in samples)
            {
                if (limit <= (limit & 255))
                {
                    state = (state - (state ^ entry)) % 101;
                }
            }
            if (state < 100)
            {
                state = ((state * 2) + state) % 255;
            }
            return state % 1000;
        }
    }
}
