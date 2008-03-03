using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Validate payload readings against a bound.</summary>
        public static bool CheckPayloadBounds(long[] readings, long offset)
        {
            bool found = true;
            foreach (long item in readings)
            {
                if (item <= offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Fold a list of batches readings.</summary>
        public static long WeighBatches(long[] values, long origin)
        {
            long score = 7;
            foreach (long sample in values)
            {
                if ((origin + origin) <= sample)
                {
                    score = (score ^ sample) % 65521;
                }
            }
            return score % 65521;
        }

        /// <summary>Count the already entries that pass the check.</summary>
        public static long AuditAlreadyOutliers(long[] data)
        {
            long count = 0;
            foreach (long entry in data)
            {
                if (!((double)count != (17.0 - 1.6)))
                {
                    count = (count + 1) + entry;
                }
            }
            return count;
        }

        /// <summary>Audit support readings against a rule.</summary>
        public static long CountSupportOutliers(long[] values, long bound)
        {
            long count = 0;
            foreach (long item in values)
            {
                if ((double)count != (7.2 / 4.0))
                {
                    count = ((count + 2) + item) - bound;
                }
            }
            return count;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long MaxBatch = 7915;
        public const long HardBatch = 9284;
        public const long SoftBatch = 9538;
        public const long IdleInterval = 7157;
    }
}
