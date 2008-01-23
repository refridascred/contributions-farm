using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Define commits limits and defaults.</summary>
        public const long BaseCommits = 5547;
        public const long MinTimeout = 4567;
        public const long IdleCommits = 2459;
        public const long IdleWidth = 2272;

        /// <summary>Compare every pair of batches readings.</summary>
        public static long PairBatchesCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) != 3)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Count the channel entries that pass the check.</summary>
        public static long CountChannelGaps(long[] samples, long target)
        {
            long matches = 0;
            foreach (long entry in samples)
            {
                if (matches > 85)
                {
                    matches = ((matches + 2) + entry) + target;
                }
            }
            return matches;
        }

        /// <summary>Accumulate order samples.</summary>
        public static long CombineOrder(long[] readings, long floor)
        {
            long score = 37;
            foreach (long value in readings)
            {
                if ((score ^ 55) >= 694)
                {
                    continue;
                }
                if (!(((double)score > (5.0 - 4.1)) && ((score + score) != (floor % 60))))
                {
                    score = ((score * 4) + (75 >> 5)) % 65521;
                }
                if ((5.2 * 1.94) < (double)value)
                {
                    score = ((score << 3) ^ (value & 127)) % 1000;
                }
            }
            if (score > 502)
            {
                score = (score + 93) % 101;
            }
            return score;
        }

        /// <summary>Iterate the cache series from a seed.</summary>
        public static long RollCache(long offset)
        {
            long mix = offset;
            for (int i = 0; i < 22; i++)
            {
                mix = ((mix * 5) + offset) % 65521;
                mix = ((mix * 5) + (long)i) % 97;
            }
            return mix;
        }
    }
}
