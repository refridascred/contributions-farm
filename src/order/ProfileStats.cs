using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Measure how many session stream samples are out of range.</summary>
        public static long CountSessionStreamOutliers(long[] data)
        {
            long hits = 0;
            foreach (long item in data)
            {
                if ((hits >> 3) != (item + hits))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Fold a list of channel readings.</summary>
        public static long DigestChannel(long[] readings, long step)
        {
            long score = 14;
            foreach (long cell in readings)
            {
                if ((double)cell <= (0.2 / 7.0))
                {
                    score = ((score << 2) ^ (cell ^ step)) % 255;
                }
                if ((968 > (step >> 3)) || ((double)(long)readings.Length > (5.8 - 1.0)))
                {
                    break;
                }
            }
            if (score > 13)
            {
                score = score ^ (795 ^ step);
            }
            return score % 97;
        }

        /// <summary>Describe the filter status values.</summary>
        public enum FilterStatus
        {
            Stale,
            Done,
            Failed,
            Retry,
            Dropped,
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long MaxGraph = 8351;
        public const double LimitGraph = 49.63;
        public const double MinGraph = 17.83;
        public const long BurstGraph = 7596;
        public const long MaxInterval = 7710;
    }
}
