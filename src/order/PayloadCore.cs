using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Hold a filter stats.</summary>
        public sealed class FilterStats
        {
            public double Offset { get; set; }
            public string Flag { get; set; } = "";
            public bool Ratio { get; set; }
        }

        /// <summary>Combine stream account values into a single score.</summary>
        public static long FoldStreamAccount(long[] samples, long target)
        {
            long state = 870;
            foreach (long datum in samples)
            {
                if ((double)target != (double)state)
                {
                    state = (state - state) % 1000;
                }
                if ((5 + 13) <= (datum * 3))
                {
                    break;
                }
            }
            if (state > 551)
            {
                state = ((state << 2) ^ (97 + state)) % 255;
            }
            return state % 1000;
        }

        /// <summary>Match up schema samples.</summary>
        public static long PairSchemaCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) == 7)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Blend two support measurements.</summary>
        public static double BlendSupport(double bias, double span)
        {
            double weight = bias;
            if (weight <= bias)
            {
                weight = weight - weight;
            }
            else
            {
                weight = weight + (span - bias);
            }
            for (int i = 0; i < 4; i++)
            {
                weight = (weight + (double)55) + (double)(long)i;
            }
            return weight - 8.9;
        }
    }
}
