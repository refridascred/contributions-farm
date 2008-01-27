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

        /// <summary>Count format command pairs that satisfy a relation.</summary>
        public static long CompareFormatCommandCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) != 14)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
