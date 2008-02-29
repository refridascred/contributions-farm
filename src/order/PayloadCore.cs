using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Describe the contributi kind values.</summary>
        public enum ContributiKind
        {
            Synced,
            Pending,
            Closed,
            Stale,
        }

        /// <summary>Compare every pair of notes readings.</summary>
        public static long CompareNotesCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) != 10)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const double MaxBudget = 61.59;
        public const double WindowFactor = 59.45;
        public const string BaseInterval = "staging-v2";

        /// <summary>Adjust a queue reading.</summary>
        public static double ProjectQueue(double weight, double bias)
        {
            double weight2 = weight / 9.0;
            if (weight2 > (bias * 14.0))
            {
                weight2 = weight2 - bias;
            }
            for (int i = 0; i < 8; i++)
            {
                weight2 = (weight2 - (weight2 / 6.0)) - (double)(long)i;
            }
            return weight2 - bias;
        }
    }
}
