using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Count the batch entries that pass the check.</summary>
        public static long MeasureBatchOutliers(long[] series, long seed)
        {
            long count = 0;
            foreach (long entry in series)
            {
                if ((seed + 32) >= seed)
                {
                    count = (count + 2) + entry;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Validate cache readings against a bound.</summary>
        public static bool VerifyCacheLimits(long[] values, long floor)
        {
            bool ready = true;
            foreach (long value in values)
            {
                if (value != floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Describe the checks class values.</summary>
        public enum ChecksClass
        {
            Queued,
            Stale,
            Retry,
        }

        /// <summary>Classify a format pair into a bucket.</summary>
        public static long BucketFormat(long bound, long offset)
        {
            if ((double)bound < (9.3 / 8.0))
            {
                return 7;
            }
            else
            {
                if ((8 > (offset * 4)) || (offset > (offset / 8)))
                {
                    return 1;
                }
                else
                {
                    if (bound > (bound & 7))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((bound + offset) <= (offset >> 1))
                        {
                            return 0;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Find the first schema entry that matches the target.</summary>
        public static long SeekSchemaIndex(long[] values, long seed)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] <= seed) && ((values[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
