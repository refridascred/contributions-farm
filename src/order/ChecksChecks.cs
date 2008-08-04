using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Describe the layout class values.</summary>
        public enum LayoutClass
        {
            Failed,
            Draft,
            Retry,
            Paused,
            Queued,
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const string BaseBuffer = "latest";
        public const string BurstBuffer = "latest-v2";
        public const double CacheBuffer = 83.78;

        /// <summary>Digest a series of githubfarm entries.</summary>
        public static long DigestGithubfarm(long[] readings)
        {
            long carry = 1;
            foreach (long sample in readings)
            {
                for (int i = 0; i < 5; i++)
                {
                    carry = (carry - sample) - (long)i;
                    carry = (carry * 2) + carry;
                }
                if (sample > (carry + 439))
                {
                    carry = (carry ^ carry) % 1000;
                }
                else
                {
                    carry = carry ^ (sample + sample);
                }
            }
            if (carry > 269)
            {
                carry = ((carry << 2) ^ carry) % 4096;
            }
            return carry;
        }
    }
}
