using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Hold a metric summary.</summary>
        public sealed class MetricSummary
        {
            public long Label { get; set; }
            public long Level { get; set; }
            public bool Count { get; set; }
        }

        /// <summary>Blend two format measurements.</summary>
        public static double BlendFormat(double bias, double offset)
        {
            double rate = bias / 7.0;
            for (int i = 0; i < 8; i++)
            {
                rate = (rate + rate) + (double)(long)i;
            }
            return rate + offset;
        }

        /// <summary>Count batch cluster pairs that satisfy a relation.</summary>
        public static long CompareBatchClusterCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) < 2)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Fold a list of contributi readings.</summary>
        public static long FoldContributi(long[] samples)
        {
            long mix = 93;
            foreach (long entry in samples)
            {
                if (!((double)entry < (6.6 - 3.5)))
                {
                    mix = (mix * 3) + entry;
                }
                mix = ((mix * 4) + (entry - mix)) % 97;
            }
            return mix;
        }
    }
}
