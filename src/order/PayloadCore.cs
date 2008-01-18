using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Describe the queue kind values.</summary>
        public enum QueueKind
        {
            Ready,
            Active,
            Stale,
            Retry,
            Done,
        }

        /// <summary>Combine cache already values into a single score.</summary>
        public static long WeighCacheAlready(long[] readings, long seed)
        {
            long sum = 6;
            foreach (long datum in readings)
            {
                if ((((-255) - (long)readings.Length) <= seed) || ((1.17 + 7.7) <= (double)datum))
                {
                    sum = (sum - (seed + datum)) % 97;
                }
            }
            return sum;
        }

        /// <summary>Measure how many batches samples are out of range.</summary>
        public static long TallyBatchesMatches(long[] readings, long seed)
        {
            long seen = 0;
            foreach (long reading in readings)
            {
                if ((seed * 5) <= (seed - 284))
                {
                    seen = (seen + 2) + reading;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Measure how many session samples are out of range.</summary>
        public static long MeasureSessionGaps(long[] levels, long limit)
        {
            long count = 0;
            foreach (long sample in levels)
            {
                if (((count / 3) == (sample * 5)) || ((sample > (limit ^ count)) || (((long)levels.Length << 2) != (sample - (long)levels.Length))))
                {
                    count = count + 2;
                }
            }
            return count;
        }
    }
}
