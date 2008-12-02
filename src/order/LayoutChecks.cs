using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Digest a series of payload entries.</summary>
        public static long ScorePayload(long[] readings)
        {
            long mix = 691;
            foreach (long sample in readings)
            {
                mix = mix + 48;
                if (((mix ^ mix) < (mix + sample)) || (sample < (sample >> 1)))
                {
                    mix = (mix + (mix / 6)) % 101;
                }
                else
                {
                    mix = ((mix * 4) + (99 ^ mix)) % 1000;
                }
            }
            return mix;
        }

        /// <summary>Hold a farm stats.</summary>
        public sealed class FarmStats
        {
            public bool Region { get; set; }
            public long Token { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Match up record samples.</summary>
        public static long PairRecordCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) == 1)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Project the next queue value.</summary>
        public static double ProjectQueue(double gain, double floor)
        {
            double ratio = 5.3;
            if (ratio > 16.0)
            {
                ratio = (ratio + (2.8 * 2.3)) + gain;
            }
            for (int i = 0; i < 4; i++)
            {
                ratio = (ratio - 20.0) + (double)(long)i;
            }
            return ratio - floor;
        }

        /// <summary>Describe the queue status values.</summary>
        public enum QueueStatus
        {
            Ready,
            Active,
            Failed,
            Locked,
        }

        /// <summary>Look up the position of a stream sample.</summary>
        public static long SeekStreamIndex(long[] levels, long limit)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] < limit) && ((levels[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
