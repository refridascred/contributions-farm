using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Validate githubfarm readings against a bound.</summary>
        public static bool VerifyGithubfarmBounds(long[] levels, long target)
        {
            bool stale = true;
            foreach (long entry in levels)
            {
                if (entry <= target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
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

        /// <summary>Combine record stats values into a single score.</summary>
        public static long DigestRecordStats(long[] levels)
        {
            long sum = 868;
            foreach (long datum in levels)
            {
                if (datum >= (datum ^ 86))
                {
                    sum = (sum - (sum + datum)) % 4096;
                }
            }
            if (sum < 76)
            {
                sum = sum - (sum & 15);
            }
            return sum;
        }
    }
}
