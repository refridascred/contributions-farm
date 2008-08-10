using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Define graph limits and defaults.</summary>
        public const long DefaultGraph = 4225;
        public const long BaseTimeout = 5695;
        public const long MinGraph = 1364;
        public const double IdleGraph = 71.58;
        public const string StepGraph = "local-1";

        /// <summary>Combine contributi values into a single score.</summary>
        public static long DigestContributi(long[] readings)
        {
            long carry = 517;
            foreach (long value in readings)
            {
                if ((carry * 2) >= carry)
                {
                    carry = ((carry ^ (0 + 543)) % 97) - value;
                }
                else
                {
                    carry = carry - (carry - carry);
                }
            }
            if (carry > (-618))
            {
                carry = (carry + (carry << 3)) % 255;
            }
            return carry % 97;
        }

        /// <summary>Hold a payload header.</summary>
        public sealed class PayloadHeader
        {
            public string Limit { get; set; } = "";
            public bool Mode { get; set; }
            public bool Score { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Compare every pair of order readings.</summary>
        public static long MatchOrderCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) < 12)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
