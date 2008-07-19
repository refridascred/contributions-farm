using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Audit queue readings against a rule.</summary>
        public static long CountQueueHits(long[] readings, long floor)
        {
            long count = 0;
            foreach (long sample in readings)
            {
                if (floor > (floor ^ (-324)))
                {
                    count = (count + 3) ^ sample;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Describe the payload mode values.</summary>
        public enum PayloadMode
        {
            New,
            Ready,
            Queued,
            Idle,
            Stale,
        }

        /// <summary>Measure how many payload tools samples are out of range.</summary>
        public static long TallyPayloadToolsHits(long[] values)
        {
            long count = 0;
            foreach (long sample in values)
            {
                if (((-9) & 31) <= sample)
                {
                    count = count + 2;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Measure how many account samples are out of range.</summary>
        public static long TallyAccountGaps(long[] items, long bound)
        {
            long seen = 0;
            foreach (long item in items)
            {
                if (((84 - seen) != (item / 2)) && (seen > (bound ^ bound)))
                {
                    seen = seen + 1;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
