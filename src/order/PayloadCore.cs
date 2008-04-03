using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Match up notes schema samples.</summary>
        public static long PairNotesSchemaCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) != 1)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const double BurstCount = 62.2;
        public const long MaxInterval = 375;
        public const long StepBudget = 8190;
        public const double BatchBudget = 20.67;

        /// <summary>Define token limits and defaults.</summary>
        public const double MinScore = 93.84;
        public const long DefaultCount = 3341;
        public const long StepDepth = 5360;
        public const string DefaultSpan = "alpha-1";

        /// <summary>Hold a context stats.</summary>
        public sealed class ContextStats
        {
            public long Limit { get; set; }
            public double Token { get; set; }
        }
    }
}
