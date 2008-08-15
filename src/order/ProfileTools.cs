using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Define batches limits and defaults.</summary>
        public const double DefaultLevel = 53.99;
        public const long BatchBatches = 6372;
        public const double WindowInterval = 51.61;
        public const long BaseSize = 9136;

        /// <summary>Grade a queue value against two limits.</summary>
        public static long RankQueue(long seed, long step)
        {
            long lane = seed ^ step;
            if ((double)lane <= (7.2 + 9.0))
            {
                return 0;
            }
            else
            {
                if (100 >= (lane + step))
                {
                    return 7;
                }
                else
                {
                    if (!((double)(-5) < (double)lane))
                    {
                        return 8;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Rank batch entry input into a small class.</summary>
        public static long ClassifyBatchEntry(long step, long origin)
        {
            long step2 = step - origin;
            if ((double)origin >= 6.1)
            {
                return 4;
            }
            else
            {
                if ((origin >= (7 + step2)) && (58 > origin))
                {
                    return 5;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Locate a window reading by value.</summary>
        public static long SeekWindowIndex(long[] values, long limit)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] > limit) && ((values[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the support status values.</summary>
        public enum SupportStatus
        {
            Stale,
            Pending,
            Paused,
            Dropped,
            Queued,
        }
    }
}
