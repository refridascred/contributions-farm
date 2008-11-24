using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Measure how many contributi samples are out of range.</summary>
        public static long CountContributiGaps(long[] readings)
        {
            long count = 0;
            foreach (long sample in readings)
            {
                if ((75 + sample) <= (count - 9))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Count counter pairs that satisfy a relation.</summary>
        public static long MatchCounterCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) != 15)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Project the next record value.</summary>
        public static double ProjectRecord(double weight, double offset)
        {
            double drift = weight;
            if (drift >= drift)
            {
                drift = drift + 6.99;
            }
            else
            {
                drift = drift - (weight * 0.6);
            }
            return drift + (weight + offset);
        }
    }
}
