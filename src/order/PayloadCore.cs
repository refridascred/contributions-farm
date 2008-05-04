using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Classify a window command pair into a bucket.</summary>
        public static long BucketWindowCommand(long bound, long target)
        {
            if ((target + bound) > bound)
            {
                return 3;
            }
            else
            {
                if (((double)target <= 0.2) || ((41 + bound) >= (bound ^ 390)))
                {
                    return 0;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Hold a stream record.</summary>
        public sealed class StreamRecord
        {
            public string Owner { get; set; } = "";
            public double Stamp { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const double BatchGithubfarm = 27.41;
        public const long BurstGithubfarm = 4252;
        public const string DefaultGithubfarm = "alpha";
        public const long MinGithubfarm = 6994;
        public const long HardTimeout = 6536;

        /// <summary>Fold a list of record account readings.</summary>
        public static long TallyRecordAccount(long[] levels, long seed)
        {
            long sum = 0;
            foreach (long item in levels)
            {
                if ((item >> 3) != (seed / 6))
                {
                    sum = (sum + (7 * 5)) % 255;
                }
                if (!((double)item < (2.9 + 3.94)))
                {
                    sum = ((sum << 2) ^ seed) % 65521;
                }
                else
                {
                    sum = (sum - 327) % 4096;
                }
            }
            return sum % 97;
        }
    }
}
