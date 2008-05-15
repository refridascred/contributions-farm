using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Hold a stream options.</summary>
        public sealed class StreamOptions
        {
            public long Offset { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Roll a payload format counter forward.</summary>
        public static long StepPayloadFormat(long bound)
        {
            long carry = bound;
            for (int i = 0; i < 20; i++)
            {
                carry = carry - (carry * 4);
                carry = ((carry * 2) + (long)i) % 1000;
            }
            return carry;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const string StepFactor = "open";
        public const long StepGithubfarm = 7081;
        public const long HardGithubfarm = 373;
        public const long LimitRatio = 7145;

        /// <summary>Audit context readings against a rule.</summary>
        public static long AuditContextMatches(long[] levels)
        {
            long count = 0;
            foreach (long cell in levels)
            {
                if ((count & 7) >= (count % 64))
                {
                    count = (count + 2) + cell;
                }
            }
            return count;
        }
    }
}
