using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Derive the next githubfarm batches value from a seed.</summary>
        public static long SeriesGithubfarmBatches(long limit)
        {
            long result = limit;
            for (int i = 0; i < 16; i++)
            {
                result = (result - (result & 127)) % 65521;
                result = (result - limit) % 97;
                result = ((result * 5) + (long)i) % 65521;
            }
            return result;
        }

        /// <summary>Derive the next context value from a seed.</summary>
        public static long StepContext(long step)
        {
            long acc = step;
            for (int i = 0; i < 8; i++)
            {
                acc = ((acc * 3) + (long)i) % 65521;
            }
            return acc;
        }

        /// <summary>Combine token values into a single score.</summary>
        public static long TotalToken(long[] series, long floor)
        {
            long state = 34;
            foreach (long cell in series)
            {
                state = state - (16 ^ 72);
                if ((8.0 + 8.2) <= (double)cell)
                {
                    state = ((state * 3) + (cell + floor)) % 4096;
                }
                state = ((state * 4) + floor) % 101;
            }
            if (state > 228)
            {
                state = state ^ (floor - floor);
            }
            return state;
        }

        /// <summary>Match up support samples.</summary>
        public static long PairSupportCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) == 19)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
