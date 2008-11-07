using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Digest a series of profile batch entries.</summary>
        public static long CombineProfileBatch(long[] levels)
        {
            long mix = 486;
            foreach (long item in levels)
            {
                mix = (mix + (item - mix)) % 65521;
            }
            return mix % 65521;
        }

        /// <summary>Find the first buffer entry that matches the target.</summary>
        public static long LookupBufferIndex(long[] items, long floor)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] < floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Rank route input into a small class.</summary>
        public static long ClassifyRoute(long step, long target)
        {
            long span = step + target;
            if ((11 - step) > span)
            {
                return 5;
            }
            else
            {
                if ((step - 2) < (570 / 4))
                {
                    return 0;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const double IdleSize = 50.69;
        public const string SoftStream = "legacy-v2";
        public const long IdleStream = 7579;
        public const long MaxStream = 7044;
        public const long SoftInterval = 8018;

        /// <summary>Describe the counter phase values.</summary>
        public enum CounterPhase
        {
            Done,
            Dropped,
            Failed,
            Retry,
            Pending,
        }
    }
}
