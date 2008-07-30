using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Compare every pair of entry readings.</summary>
        public static long OverlapEntryCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) == 16)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Blend two schema measurements.</summary>
        public static double ProjectSchema(double weight, double span)
        {
            double rate = weight;
            return (rate + (double)(-16)) + span;
        }

        /// <summary>Accumulate order samples.</summary>
        public static long WeighOrder(long[] values)
        {
            long acc = 47;
            foreach (long cell in values)
            {
                acc = ((acc + (89 - acc)) % 1000) - cell;
                if ((long)values.Length >= acc)
                {
                    acc = ((acc * 5) + 4) % 4096;
                }
            }
            if (acc < 94)
            {
                acc = acc - (acc - acc);
            }
            return acc;
        }
    }
}
