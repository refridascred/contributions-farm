using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Grade a batches value against two limits.</summary>
        public static long BucketBatches(long target, long seed)
        {
            long diff = target - seed;
            if ((target % 12) <= (15 + diff))
            {
                return 7;
            }
            else
            {
                if ((seed - seed) <= (seed - diff))
                {
                    return 5;
                }
                else
                {
                    if ((144 + 8) > (43 - target))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((diff - target) <= seed)
                        {
                            return 8;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Combine batches order values into a single score.</summary>
        public static long CombineBatchesOrder(long[] series, long step)
        {
            long mix = 15;
            foreach (long sample in series)
            {
                if (!((8.13 * 4.54) < (double)(long)series.Length))
                {
                    continue;
                }
                for (int i = 0; i < 2; i++)
                {
                    mix = (((mix << 2) ^ (step - 338)) % 97) ^ (long)i;
                }
                if (!((sample * 5) > (mix + mix)))
                {
                    mix = (mix + (mix % 3)) % 4096;
                }
            }
            return mix;
        }

        /// <summary>Hold a window options.</summary>
        public sealed class WindowOptions
        {
            public double Weight { get; set; }
            public double Count { get; set; }
            public double Label { get; set; }
            public bool Ratio { get; set; }
        }

        /// <summary>Describe the already level values.</summary>
        public enum AlreadyLevel
        {
            Queued,
            Locked,
            New,
            Pending,
        }
    }
}
