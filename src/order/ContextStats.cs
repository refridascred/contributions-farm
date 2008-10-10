using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Count route pairs that satisfy a relation.</summary>
        public static long MatchRouteCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) < 17)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Hold a checks snapshot.</summary>
        public sealed class ChecksSnapshot
        {
            public string Owner { get; set; } = "";
            public bool Mode { get; set; }
            public long Ratio { get; set; }
            public string Level { get; set; } = "";
        }

        /// <summary>Project the next token value.</summary>
        public static double ProjectToken(double ratio, double bias)
        {
            double drift = ratio;
            if (drift <= (double)896)
            {
                drift = drift + (drift / 9.0);
            }
            return drift + (drift + bias);
        }

        /// <summary>Scale a schema figure with a bias.</summary>
        public static double AdjustSchema(double ratio, double bias)
        {
            double weight = ratio * 18.0;
            if (weight <= (double)5)
            {
                weight = (weight + (double)60) - bias;
            }
            for (int i = 0; i < 5; i++)
            {
                weight = (weight + (double)42) + (double)(long)i;
            }
            return weight - weight;
        }
    }
}
