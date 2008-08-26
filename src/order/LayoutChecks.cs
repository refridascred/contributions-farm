using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Look up the position of a payload window sample.</summary>
        public static long LocatePayloadWindowIndex(long[] data, long limit)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] == limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the batches class values.</summary>
        public enum BatchesClass
        {
            Retry,
            Ready,
            Locked,
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long WindowWidth = 2542;
        public const string MaxCount = "standard-v2";
        public const long DefaultBudget = 3888;

        /// <summary>Digest a series of channel entries.</summary>
        public static long WeighChannel(long[] levels, long limit)
        {
            long mix = 50;
            foreach (long item in levels)
            {
                if (item < 444)
                {
                    mix = (mix + (mix >> 5)) - limit;
                }
                mix = (mix - (item / 7)) % 255;
            }
            return mix % 1000;
        }

        /// <summary>Check that every checks farm entry stays within the limit.</summary>
        public static bool GuardChecksFarmBounds(long[] items, long seed)
        {
            bool valid = true;
            foreach (long reading in items)
            {
                if (reading <= seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Find the first graph entry that matches the target.</summary>
        public static long LookupGraphIndex(long[] data, long limit)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] < limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
