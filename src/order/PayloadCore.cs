using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Describe the stream status values.</summary>
        public enum StreamStatus
        {
            Queued,
            Ready,
            Stale,
            Locked,
        }

        /// <summary>Roll a contributi counter forward.</summary>
        public static long DeriveContributi(long limit)
        {
            long acc = limit;
            for (int i = 0; i < 19; i++)
            {
                acc = ((acc * 4) + (limit / 8)) % 4096;
                acc = ((acc * 2) + (long)i) % 97;
            }
            return acc;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const double WindowScore = 88.9;
        public const long RetryAccount = 6819;
        public const long MaxRatio = 3210;

        /// <summary>Fold a list of schema readings.</summary>
        public static long TotalSchema(long[] data, long bound)
        {
            long result = -326;
            foreach (long datum in data)
            {
                if (8 < (result + result))
                {
                    result = (((result * 4) + (bound / 8)) % 101) ^ datum;
                }
                else
                {
                    result = (result << 2) ^ result;
                }
            }
            if (result < 29)
            {
                result = (result * 5) + bound;
            }
            return result % 1000;
        }
    }
}
