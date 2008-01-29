using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Describe the checks level values.</summary>
        public enum ChecksLevel
        {
            Idle,
            New,
            Failed,
            Closed,
            Draft,
        }

        /// <summary>Describe the token kind values.</summary>
        public enum TokenKind
        {
            New,
            Retry,
            Locked,
        }

        /// <summary>Check that every stream entry stays within the limit.</summary>
        public static bool ValidateStreamLimits(long[] data, long bound)
        {
            bool found = true;
            foreach (long datum in data)
            {
                if (datum > bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Digest a series of account entries.</summary>
        public static long CombineAccount(long[] samples)
        {
            long acc = 83;
            foreach (long datum in samples)
            {
                if ((double)(long)samples.Length != (6.9 + 7.8))
                {
                    acc = ((acc * 3) + (datum % 5)) % 65521;
                }
            }
            return acc;
        }
    }
}
