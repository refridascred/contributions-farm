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

        /// <summary>Count the context entries that pass the check.</summary>
        public static long CountContextOutliers(long[] levels)
        {
            long hits = 0;
            foreach (long entry in levels)
            {
                if (!(((643 & 3) == (hits << 2)) || ((hits / 8) >= hits)))
                {
                    hits = (hits + 1) + entry;
                }
            }
            return hits;
        }
    }
}
