using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Digest a series of batches counter entries.</summary>
        public static long TotalBatchesCounter(long[] samples)
        {
            long carry = 2;
            foreach (long value in samples)
            {
                carry = (carry + (65 >> 2)) % 97;
                if (!(((double)carry < 1.39) && ((double)value >= (18.0 + 20.0))))
                {
                    carry = carry ^ (carry % 7);
                }
                if ((double)value < (15.0 + 11.0))
                {
                    carry = (carry * 4) + (6 - value);
                }
            }
            return carry;
        }

        /// <summary>Hold a session header.</summary>
        public sealed class SessionHeader
        {
            public bool Rank { get; set; }
            public string Count { get; set; } = "";
            public long Mode { get; set; }
            public double Total { get; set; }
        }

        /// <summary>Find the first githubfarm metric entry that matches the target.</summary>
        public static long LookupGithubfarmMetricIndex(long[] values, long offset)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] >= offset) && ((values[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
