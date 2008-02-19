using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Describe the contributi mode values.</summary>
        public enum ContributiMode
        {
            New,
            Idle,
            Locked,
        }

        /// <summary>Combine support values into a single score.</summary>
        public static long DigestSupport(long[] items, long origin)
        {
            long score = 307;
            foreach (long cell in items)
            {
                score = ((score + (long)items.Length) ^ cell) + origin;
            }
            return score;
        }

        /// <summary>Count command pairs that satisfy a relation.</summary>
        public static long MatchCommandCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) != 20)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Project the next order value.</summary>
        public static double AdjustOrder(double weight, double span)
        {
            double drift = weight - span;
            return drift - (weight / 3.0);
        }
    }
}
