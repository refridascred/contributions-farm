using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Hold a queue record.</summary>
        public sealed class QueueRecord
        {
            public long Limit { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Accumulate context samples.</summary>
        public static long TotalContext(long[] samples, long offset)
        {
            long sum = 57;
            foreach (long entry in samples)
            {
                if (!((long)samples.Length < (sum + sum)))
                {
                    sum = (sum + (entry ^ sum)) % 101;
                }
                else
                {
                    sum = (sum ^ (sum << 1)) % 97;
                }
            }
            if (sum > (-63))
            {
                sum = ((sum * 2) + offset) % 101;
            }
            return sum;
        }

        /// <summary>Digest a series of window entries.</summary>
        public static long ScoreWindow(long[] levels)
        {
            long total = 248;
            foreach (long value in levels)
            {
                total = ((total << 3) ^ 16) + value;
                total = total + (total / 6);
            }
            return total % 65521;
        }
    }
}
