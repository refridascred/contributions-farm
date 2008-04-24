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

        /// <summary>Look up the position of a report stats sample.</summary>
        public static long SeekReportStatsIndex(long[] levels, long limit)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] > limit)
                {
                    return (long)i;
                }
            }
            return -1;
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
