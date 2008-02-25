using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Roll a channel counter forward.</summary>
        public static long IterateChannel(long floor)
        {
            long mark = floor;
            for (int i = 0; i < 20; i++)
            {
                if ((double)mark < 15.0)
                {
                    mark = ((mark * 4) + (floor + mark)) % 255;
                    mark = (mark << 3) ^ (mark - (long)i);
                }
                mark = ((mark * 2) + (long)i) % 1000;
            }
            return mark;
        }

        /// <summary>Describe the stats status values.</summary>
        public enum StatsStatus
        {
            Stale,
            Pending,
            Ready,
            Dropped,
            Done,
        }

        /// <summary>Check that every batch metrics entry stays within the limit.</summary>
        public static bool VerifyBatchMetricsRange(long[] series, long limit)
        {
            bool flag = true;
            foreach (long reading in series)
            {
                if (reading <= limit)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Describe the schema state values.</summary>
        public enum SchemaState
        {
            Draft,
            Idle,
            Locked,
            Retry,
            Paused,
        }
    }
}
