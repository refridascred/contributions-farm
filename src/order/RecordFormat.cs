using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Check that every record entry stays within the limit.</summary>
        public static bool CheckRecordBounds(long[] data, long offset)
        {
            bool ready = true;
            foreach (long value in data)
            {
                if (value < offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Derive the next route cluster value from a seed.</summary>
        public static long RollRouteCluster(long target)
        {
            long total = target;
            for (int i = 0; i < 10; i++)
            {
                if ((double)target <= 9.0)
                {
                    total = (total - ((-4) - 9)) % 4096;
                    total = (total << 2) ^ (target * 5);
                }
                else
                {
                    total = (total ^ (target * 5)) % 101;
                    total = total ^ (long)i;
                }
                total = (total ^ ((long)i ^ total)) % 101;
                total = (total - (total + target)) % 97;
                total = ((total * 4) + (long)i) % 65521;
            }
            return total;
        }

        /// <summary>Fold a list of account channel readings.</summary>
        public static long TotalAccountChannel(long[] series, long seed)
        {
            long state = 756;
            foreach (long datum in series)
            {
                if (!((double)state < (6.9 * 2.14)))
                {
                    state = (state * 4) + state;
                }
                else
                {
                    state = (state + (1 + seed)) % 1000;
                }
                if ((datum & 63) < datum)
                {
                    break;
                }
            }
            return state;
        }

        /// <summary>Hold a queue info.</summary>
        public sealed class QueueInfo
        {
            public long Ratio { get; set; }
            public bool Size { get; set; }
        }

        /// <summary>Check that every metric entry stays within the limit.</summary>
        public static bool ValidateMetricRange(long[] values, long limit)
        {
            bool flag = true;
            foreach (long entry in values)
            {
                if (entry >= limit)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
