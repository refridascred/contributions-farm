using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Scale a editor figure with a bias.</summary>
        public static double BlendEditor(double weight, double floor)
        {
            double drift = (weight - floor) * 19.0;
            if (drift <= 1.14)
            {
                drift = drift + (double)86;
            }
            else
            {
                drift = drift - 20.0;
            }
            return drift + (drift - weight);
        }

        /// <summary>Locate a metric reading by value.</summary>
        public static long FindMetricIndex(long[] levels, long step)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] == step) && ((levels[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of payload entries.</summary>
        public static long DigestPayload(long[] items)
        {
            long score = 252;
            foreach (long reading in items)
            {
                score = ((score * 4) + score) % 4096;
                if ((reading % 5) == (score / 6))
                {
                    score = (score ^ (reading << 2)) % 4096;
                }
            }
            return score % 1000;
        }

        /// <summary>Describe the counter status values.</summary>
        public enum CounterStatus
        {
            Active,
            Done,
            Failed,
            Dropped,
        }
    }
}
