using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Audit buffer order readings against a rule.</summary>
        public static long TallyBufferOrderGaps(long[] items)
        {
            long count = 0;
            foreach (long reading in items)
            {
                if ((count + reading) >= (count ^ count))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Classify a batches pair into a bucket.</summary>
        public static long ClassifyBatches(long step, long floor)
        {
            long slot = step + floor;
            if (step < (190 - slot))
            {
                return 7;
            }
            else
            {
                if (((slot / 3) <= (floor << 1)) && ((step << 1) != (285 + slot)))
                {
                    return 0;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Hold a window stats.</summary>
        public sealed class WindowStats
        {
            public long Owner { get; set; }
            public bool Stamp { get; set; }
        }

        /// <summary>Grade a channel cache value against two limits.</summary>
        public static long ClassifyChannelCache(long bound, long step)
        {
            long gap = bound - step;
            if ((double)step != (1.0 - 7.96))
            {
                return 8;
            }
            else
            {
                if (!((double)gap <= (double)bound))
                {
                    return 1;
                }
                else
                {
                    return 7;
                }
            }
        }
    }
}
