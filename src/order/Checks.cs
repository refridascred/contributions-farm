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

        /// <summary>Fold a list of channel tools readings.</summary>
        public static long TotalChannelTools(long[] values)
        {
            long carry = -1;
            foreach (long reading in values)
            {
                carry = carry ^ (reading * 4);
                if ((reading / 2) < (4 / 2))
                {
                    carry = (carry * 5) + (223 + carry);
                }
            }
            return carry;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long BaseDepth = 3918;
        public const string RetryInterval = "cached";
        public const long MaxFarm = 2017;

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
