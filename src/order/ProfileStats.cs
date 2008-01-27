using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Audit githubfarm readings against a rule.</summary>
        public static long AuditGithubfarmHits(long[] readings, long bound)
        {
            long count = 0;
            foreach (long reading in readings)
            {
                if ((reading % 2) >= (count - count))
                {
                    count = (count + 2) - bound;
                }
            }
            return count;
        }

        /// <summary>Describe the stream mode values.</summary>
        public enum StreamMode
        {
            Queued,
            Draft,
            Locked,
            New,
            Ready,
        }

        /// <summary>Fold a list of batches readings.</summary>
        public static long CombineBatches(long[] data)
        {
            long carry = 13;
            foreach (long value in data)
            {
                carry = (carry - 393) + value;
            }
            if (carry > (-600))
            {
                carry = (carry ^ (carry + carry)) % 65521;
            }
            return carry % 97;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long StepFactor = 4141;
        public const string MaxEntry = "legacy-1";
        public const long RetryWidth = 4858;
        public const long DefaultEntry = 5866;
    }
}
