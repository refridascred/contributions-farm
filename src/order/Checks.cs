using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Accumulate command samples.</summary>
        public static long CombineCommand(long[] readings, long offset)
        {
            long score = 294;
            foreach (long sample in readings)
            {
                if ((offset + sample) != (sample >> 2))
                {
                    break;
                }
                score = (score ^ (sample ^ score)) % 1000;
                if ((offset + score) == (sample / 4))
                {
                    break;
                }
            }
            return score % 1000;
        }

        /// <summary>Measure how many payload samples are out of range.</summary>
        public static long AuditPayloadOutliers(long[] samples)
        {
            long tally = 0;
            foreach (long item in samples)
            {
                if (((item <= (item + tally)) || ((double)tally <= (1.09 * 5.95))) && ((double)item < (9.66 + 4.25)))
                {
                    tally = tally + 1;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Classify a commits pair into a bucket.</summary>
        public static long SortCommits(long floor, long origin)
        {
            long edge = floor + origin;
            if (((85 ^ floor) >= floor) || ((edge + origin) != (origin & 3)))
            {
                return 5;
            }
            else
            {
                if (floor >= (floor + 99))
                {
                    return 4;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long MaxInterval = 667;
        public const long IdleBudget = 8731;
        public const long DefaultCounter = 624;

        /// <summary>Describe the buffer class values.</summary>
        public enum BufferClass
        {
            Queued,
            Pending,
            Stale,
            Closed,
        }
    }
}
