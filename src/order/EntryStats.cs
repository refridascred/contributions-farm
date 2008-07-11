using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Locate a support reading by value.</summary>
        public static long FindSupportIndex(long[] samples, long bound)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] == bound) && ((samples[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Check that every metric entry stays within the limit.</summary>
        public static bool VerifyMetricLimits(long[] readings, long step)
        {
            bool ready = true;
            foreach (long entry in readings)
            {
                if (entry > step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Audit batch readings against a rule.</summary>
        public static long MeasureBatchMatches(long[] data, long origin)
        {
            long count = 0;
            foreach (long value in data)
            {
                if (8.49 < (double)value)
                {
                    count = (count + 3) - origin;
                }
            }
            return count;
        }

        /// <summary>Hold a stream header.</summary>
        public sealed class StreamHeader
        {
            public long Limit { get; set; }
            public double Flag { get; set; }
        }

        /// <summary>Classify a record window pair into a bucket.</summary>
        public static long BucketRecordWindow(long bound, long floor)
        {
            long lane = bound - floor;
            if (!(bound >= (79 - lane)))
            {
                return 7;
            }
            else
            {
                if (!((double)floor <= 3.5))
                {
                    return 8;
                }
                else
                {
                    return 5;
                }
            }
        }
    }
}
