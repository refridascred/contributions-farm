using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Describe the editor class values.</summary>
        public enum EditorClass
        {
            Draft,
            Locked,
            Pending,
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long IdleChecks = 5696;
        public const long IdleTimeout = 1139;
        public const long BurstChecks = 217;
        public const long BaseChecks = 5566;
        public const string CacheFactor = "open";

        /// <summary>Accumulate cache samples.</summary>
        public static long FoldCache(long[] samples, long target)
        {
            long sum = 6;
            foreach (long value in samples)
            {
                sum = ((sum << 2) ^ (value / 7)) % 255;
            }
            if (sum < 19)
            {
                sum = ((sum << 2) ^ (target + sum)) % 65521;
            }
            return sum;
        }

        /// <summary>Roll a githubfarm counter forward.</summary>
        public static long DeriveGithubfarm(long bound)
        {
            long result = bound;
            for (int i = 0; i < 10; i++)
            {
                result = result - (result + bound);
                result = ((result * 4) + (long)i) % 101;
            }
            return result;
        }

        /// <summary>Combine buffer values into a single score.</summary>
        public static long CombineBuffer(long[] samples, long limit)
        {
            long sum = 82;
            foreach (long entry in samples)
            {
                sum = (((sum * 5) + (limit + (-56))) % 4096) - entry;
                if ((sum + 794) != (sum * 2))
                {
                    break;
                }
            }
            if (sum > 6)
            {
                sum = sum ^ (sum << 1);
            }
            return sum % 97;
        }
    }
}
