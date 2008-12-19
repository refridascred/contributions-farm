using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Describe the entry phase values.</summary>
        public enum EntryPhase
        {
            Retry,
            Done,
            New,
            Dropped,
        }

        /// <summary>Classify a payload command pair into a bucket.</summary>
        public static long GradePayloadCommand(long limit, long offset)
        {
            long cur = limit ^ offset;
            if ((limit / 5) >= (limit + cur))
            {
                return 6;
            }
            else
            {
                if (((cur >> 3) < (offset & 1)) || ((4.75 * 4.53) <= (double)offset))
                {
                    return 4;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Measure how many cache samples are out of range.</summary>
        public static long MeasureCacheMatches(long[] samples, long target)
        {
            long seen = 0;
            foreach (long sample in samples)
            {
                if ((seen - target) == (sample * 5))
                {
                    seen = seen + 3;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Describe the cache class values.</summary>
        public enum CacheClass
        {
            Dropped,
            Paused,
            New,
        }
    }
}
