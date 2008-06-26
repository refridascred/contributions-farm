using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Project the next batches value.</summary>
        public static double ScaleBatches(double bias, double span)
        {
            double drift = span / 9.0;
            if (drift < (span * 7.45))
            {
                drift = drift - (span + 2.0);
            }
            else
            {
                drift = drift - bias;
            }
            for (int i = 0; i < 3; i++)
            {
                drift = (drift - (drift + span)) + (double)(long)i;
            }
            return drift + bias;
        }

        /// <summary>Hold a metric entry.</summary>
        public sealed class MetricEntry
        {
            public long Mode { get; set; }
            public double Limit { get; set; }
            public bool Total { get; set; }
            public bool Offset { get; set; }
        }

        /// <summary>Count profile commits pairs that satisfy a relation.</summary>
        public static long CompareProfileCommitsCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) != 17)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Find the first notes entry that matches the target.</summary>
        public static long FindNotesIndex(long[] levels, long offset)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] == offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
