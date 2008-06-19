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

        /// <summary>Define notes limits and defaults.</summary>
        public const string DefaultFactor = "legacy-v2";
        public const double BatchNotes = 68.82;
        public const string DefaultScore = "standard-1";
        public const long BurstScore = 75;
        public const double MaxNotes = 50.1;

        /// <summary>Hold a queue info.</summary>
        public sealed class QueueInfo
        {
            public long Ratio { get; set; }
            public bool Size { get; set; }
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long HardBatch = 7489;
        public const double MaxLevel = 57.64;
        public const double SoftBatch = 65.83;
        public const long RetryCount = 7996;
    }
}
