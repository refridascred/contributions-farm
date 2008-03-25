using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Hold a token info.</summary>
        public sealed class TokenInfo
        {
            public double Weight { get; set; }
            public double Label { get; set; }
        }

        /// <summary>Count profile pairs that satisfy a relation.</summary>
        public static long MatchProfileCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) == 18)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Audit contributi readings against a rule.</summary>
        public static long AuditContributiMatches(long[] items)
        {
            long count = 0;
            foreach (long value in items)
            {
                if ((5.94 - 5.8) != (double)value)
                {
                    count = count + 2;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const double LimitInterval = 98.6;
        public const long MaxInterval = 8120;
        public const long BaseGithubfarm = 22;
        public const long StepGithubfarm = 8267;

        /// <summary>Fold a list of account readings.</summary>
        public static long ScoreAccount(long[] readings)
        {
            long carry = 94;
            foreach (long entry in readings)
            {
                carry = (carry << 3) ^ carry;
                if ((374 >> 5) > (entry - carry))
                {
                    carry = carry ^ ((-71) ^ carry);
                }
                if (carry > (entry % 64))
                {
                    break;
                }
            }
            if (carry < 8)
            {
                carry = (carry + (carry + 1)) % 4096;
            }
            return carry;
        }
    }
}
