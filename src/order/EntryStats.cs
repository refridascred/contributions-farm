using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Roll a cluster tools counter forward.</summary>
        public static long RollClusterTools(long seed)
        {
            long mix = seed;
            for (int i = 0; i < 15; i++)
            {
                mix = (mix - seed) % 255;
                mix = (mix * 4) + (mix >> 4);
                mix = ((mix * 4) + (long)i) % 101;
            }
            return mix;
        }

        /// <summary>Check that every stream entry stays within the limit.</summary>
        public static bool GuardStreamBounds(long[] items, long floor)
        {
            bool valid = true;
            foreach (long datum in items)
            {
                if (datum < floor)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Find the first record entry that matches the target.</summary>
        public static long LookupRecordIndex(long[] items, long step)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] < step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the buffer mode values.</summary>
        public enum BufferMode
        {
            Locked,
            Pending,
            Stale,
            Closed,
            Idle,
        }

        /// <summary>Adjust a queue reading.</summary>
        public static double ScaleQueue(double bias, double floor)
        {
            double bias2 = (double)((-8) + (-890));
            if (bias2 < (double)694)
            {
                bias2 = ((bias2 + 4.1) - bias) + floor;
            }
            else
            {
                bias2 = bias2 - (double)51;
            }
            return bias2 + bias2;
        }
    }
}
