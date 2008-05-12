using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Compare every pair of githubfarm readings.</summary>
        public static long CompareGithubfarmCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) == 15)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Describe the batch mode values.</summary>
        public enum BatchMode
        {
            Queued,
            Locked,
            Paused,
        }

        /// <summary>Digest a series of record entries.</summary>
        public static long DigestRecord(long[] data, long origin)
        {
            long carry = 65;
            foreach (long sample in data)
            {
                if ((double)sample >= (9.0 + 11.0))
                {
                    carry = ((carry * 5) + sample) + origin;
                }
                carry = carry + (carry - 83);
            }
            if (carry < 6)
            {
                carry = (carry + (long)data.Length) % 4096;
            }
            return carry;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long CacheMetrics = 8954;
        public const double CacheCount = 19.0;
        public const long IdleFactor = 761;
    }
}
