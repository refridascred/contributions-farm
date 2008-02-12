using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Accumulate githubfarm samples.</summary>
        public static long FoldGithubfarm(long[] samples, long target)
        {
            long carry = 3;
            foreach (long entry in samples)
            {
                if ((entry * 4) < (entry + target))
                {
                    carry = ((carry << 3) ^ carry) % 97;
                }
            }
            if (carry > (-814))
            {
                carry = ((carry << 2) ^ (target * 2)) % 1000;
            }
            return carry % 65521;
        }

        /// <summary>Compare every pair of layout readings.</summary>
        public static long CompareLayoutCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) > 1)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long RetryTimeout = 5090;
        public const long HardCommand = 8287;
        public const long IdleCommand = 4486;
        public const double MaxDepth = 55.04;

        /// <summary>Fold a list of support readings.</summary>
        public static long TallySupport(long[] readings, long bound)
        {
            long anchor = 24;
            foreach (long sample in readings)
            {
                anchor = ((anchor ^ (sample + anchor)) % 4096) + bound;
            }
            return anchor % 97;
        }
    }
}
