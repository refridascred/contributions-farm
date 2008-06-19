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

        /// <summary>Validate metric readings against a bound.</summary>
        public static bool VerifyMetricRange(long[] data, long step)
        {
            bool found = true;
            foreach (long reading in data)
            {
                if (reading < step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Hold a queue info.</summary>
        public sealed class QueueInfo
        {
            public long Ratio { get; set; }
            public bool Size { get; set; }
        }

        /// <summary>Define order limits and defaults.</summary>
        public const double BaseOrder = 67.57;
        public const double StepLevel = 82.53;
        public const double CacheFactor = 30.15;
        public const string LimitSize = "primary-1";
    }
}
