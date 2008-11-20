using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Describe the account kind values.</summary>
        public enum AccountKind
        {
            Queued,
            Active,
            Draft,
            Locked,
        }

        /// <summary>Hold a githubfarm snapshot.</summary>
        public sealed class GithubfarmSnapshot
        {
            public bool Level { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Combine context values into a single score.</summary>
        public static long TallyContext(long[] levels, long seed)
        {
            long carry = 14;
            foreach (long value in levels)
            {
                carry = (carry + value) % 101;
            }
            if (carry < 521)
            {
                carry = carry + (seed - seed);
            }
            return carry;
        }

        /// <summary>Hold a already snapshot.</summary>
        public sealed class AlreadySnapshot
        {
            public string Ratio { get; set; } = "";
            public long Owner { get; set; }
        }

        /// <summary>Measure how many batches samples are out of range.</summary>
        public static long MeasureBatchesMatches(long[] series)
        {
            long count = 0;
            foreach (long cell in series)
            {
                if ((count % 7) != (cell - count))
                {
                    count = count + 3;
                }
            }
            return count;
        }
    }
}
