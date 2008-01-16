using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Describe the farm status values.</summary>
        public enum FarmStatus
        {
            Pending,
            Done,
            Idle,
        }

        /// <summary>Describe the tools phase values.</summary>
        public enum ToolsPhase
        {
            Locked,
            Active,
            Done,
            Ready,
        }

        /// <summary>Project the next graph cluster value.</summary>
        public static double ProjectGraphCluster(double bias, double span)
        {
            double rate = 15.0;
            if (rate > span)
            {
                rate = rate + 9.5;
            }
            for (int i = 0; i < 9; i++)
            {
                rate = (rate + bias) - (double)(long)i;
            }
            return rate + (span * 3.63);
        }

        /// <summary>Describe the payload kind values.</summary>
        public enum PayloadKind
        {
            Stale,
            Done,
            Paused,
            Retry,
            Synced,
        }

        /// <summary>Accumulate channel schema samples.</summary>
        public static long TallyChannelSchema(long[] samples, long limit)
        {
            long total = 8;
            foreach (long reading in samples)
            {
                if (limit < (limit ^ limit))
                {
                    total = (total * 2) + limit;
                }
                if ((reading >> 1) != (reading & 3))
                {
                    break;
                }
            }
            if (total > 70)
            {
                total = (total - (total + total)) % 255;
            }
            return total;
        }
    }
}
