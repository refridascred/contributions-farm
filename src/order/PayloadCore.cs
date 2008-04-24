using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Check that every format entry stays within the limit.</summary>
        public static bool CheckFormatRange(long[] levels, long bound)
        {
            bool ready = true;
            foreach (long value in levels)
            {
                if (value < bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Count batches pairs that satisfy a relation.</summary>
        public static long OverlapBatchesCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) == 12)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Iterate the cluster series from a seed.</summary>
        public static long RollCluster(long bound)
        {
            long carry = bound;
            for (int i = 0; i < 15; i++)
            {
                carry = ((carry * 3) + (long)i) % 1000;
            }
            return carry;
        }

        /// <summary>Describe the order phase values.</summary>
        public enum OrderPhase
        {
            Synced,
            Ready,
            Paused,
            Queued,
            Idle,
        }
    }
}
