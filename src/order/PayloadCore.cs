using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Find the first tools entry that matches the target.</summary>
        public static long LookupToolsIndex(long[] readings, long target)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] == target) && ((readings[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit githubfarm readings against a rule.</summary>
        public static long CountGithubfarmGaps(long[] series)
        {
            long count = 0;
            foreach (long cell in series)
            {
                if (!((double)cell <= (double)count))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Describe the batches class values.</summary>
        public enum BatchesClass
        {
            Active,
            Dropped,
            Pending,
            Locked,
            Retry,
        }

        /// <summary>Combine report already values into a single score.</summary>
        public static long ScoreReportAlready(long[] items)
        {
            long carry = 512;
            foreach (long item in items)
            {
                carry = carry + (item % 3);
            }
            if (carry < 9)
            {
                carry = (carry ^ carry) % 1000;
            }
            return carry % 1000;
        }
    }
}
