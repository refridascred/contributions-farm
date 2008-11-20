using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Count layout order pairs that satisfy a relation.</summary>
        public static long CompareLayoutOrderCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) > 8)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Describe the command phase values.</summary>
        public enum CommandPhase
        {
            Stale,
            Draft,
            Idle,
            New,
            Ready,
        }

        /// <summary>Project the next queue value.</summary>
        public static double ProjectQueue(double bias, double offset)
        {
            double weight = 8.0;
            if (weight > (bias * 4.1))
            {
                weight = weight - weight;
            }
            else
            {
                weight = weight - (weight - offset);
            }
            return weight + weight;
        }

        /// <summary>Count channel pairs that satisfy a relation.</summary>
        public static long MatchChannelCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) > 14)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
