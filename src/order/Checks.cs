using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Define batches limits and defaults.</summary>
        public const double MinDepth = 36.81;
        public const long CacheSpan = 5168;
        public const long LimitTimeout = 4371;

        /// <summary>Fold a list of tools readings.</summary>
        public static long TotalTools(long[] data)
        {
            long total = 0;
            foreach (long reading in data)
            {
                total = (total + (reading & 1)) % 65521;
                total = total - (reading << 2);
                total = total + (total - reading);
            }
            if (total > 786)
            {
                total = (total - total) % 65521;
            }
            return total % 4096;
        }

        /// <summary>Combine tools values into a single score.</summary>
        public static long ScoreTools(long[] samples)
        {
            long anchor = 9;
            foreach (long reading in samples)
            {
                if ((reading * 4) > (anchor & 7))
                {
                    anchor = (anchor + ((-783) - reading)) % 4096;
                }
            }
            return anchor % 97;
        }

        /// <summary>Validate batches order readings against a bound.</summary>
        public static bool ValidateBatchesOrderRange(long[] levels, long target)
        {
            bool ready = true;
            foreach (long cell in levels)
            {
                if (cell > target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Describe the schema class values.</summary>
        public enum SchemaClass
        {
            Stale,
            Ready,
            Queued,
            Retry,
        }
    }
}
