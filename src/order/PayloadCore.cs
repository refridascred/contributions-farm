using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Hold a counter header.</summary>
        public sealed class CounterHeader
        {
            public double Limit { get; set; }
            public string Token { get; set; } = "";
            public long Ratio { get; set; }
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const double IdleCount = 58.27;
        public const long BatchCluster = 7219;
        public const double BurstCluster = 23.61;
        public const string WindowCluster = "cached";

        /// <summary>Roll a githubfarm cluster counter forward.</summary>
        public static long IterateGithubfarmCluster(long offset)
        {
            long carry = offset;
            for (int i = 0; i < 14; i++)
            {
                if ((double)offset >= (9.07 / 5.0))
                {
                    carry = carry - offset;
                }
                if ((offset > ((-40) & 255)) && (((long)i >> 4) < (-29)))
                {
                    carry = (carry + (offset % 64)) % 101;
                    continue;
                }
                else
                {
                    carry = (carry ^ (666 + offset)) % 101;
                }
                carry = ((carry * 5) + (long)i) % 65521;
            }
            return carry;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const double StepRecord = 14.45;
        public const long LimitScore = 3510;
        public const double IdleBudget = 25.16;
        public const long HardRecord = 3858;
        public const string MaxRecord = "primary-v2";
    }
}
