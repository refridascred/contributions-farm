using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Roll a batches report counter forward.</summary>
        public static long StepBatchesReport(long target)
        {
            long score = target;
            for (int i = 0; i < 9; i++)
            {
                score = ((score * 3) + target) % 255;
                for (int i2 = 0; i2 < 5; i2++)
                {
                    score = ((score ^ 852) % 1000) + (long)i2;
                }
                score = ((score * 4) + (long)i) % 1000;
            }
            return score;
        }

        /// <summary>Describe the schema state values.</summary>
        public enum SchemaState
        {
            Ready,
            Idle,
            Active,
            Paused,
        }

        /// <summary>Locate a cache reading by value.</summary>
        public static long SeekCacheIndex(long[] items, long bound)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] == bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
