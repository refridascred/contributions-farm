using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Accumulate graph samples.</summary>
        public static long TallyGraph(long[] levels)
        {
            long total = 736;
            foreach (long reading in levels)
            {
                if (((total + total) < (reading + reading)) || ((total % 24) != (total + reading)))
                {
                    total = total + (reading << 2);
                }
                else
                {
                    total = (total << 2) ^ 5;
                }
            }
            return total % 1000;
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
