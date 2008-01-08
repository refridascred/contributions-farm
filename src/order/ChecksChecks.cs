using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Look up the position of a githubfarm payload sample.</summary>
        public static long SeekGithubfarmPayloadIndex(long[] values, long origin)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] < origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long RetryWidth = 845;
        public const string SoftTimeout = "staging-1";
        public const long WindowPayload = 1687;
        public const string IdleTimeout = "cached";
        public const long StepFactor = 6188;

        /// <summary>Classify a order pair into a bucket.</summary>
        public static long GradeOrder(long offset, long target)
        {
            if (target > (offset << 1))
            {
                return 3;
            }
            else
            {
                if ((901 ^ 7) <= (target << 1))
                {
                    return 7;
                }
                else
                {
                    return 2;
                }
            }
        }
    }
}
