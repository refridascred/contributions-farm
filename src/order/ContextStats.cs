using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Locate a profile reading by value.</summary>
        public static long SeekProfileIndex(long[] data, long origin)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] <= origin) && ((data[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a schema options.</summary>
        public sealed class SchemaOptions
        {
            public double Mode { get; set; }
            public long Ratio { get; set; }
            public double Limit { get; set; }
            public double Count { get; set; }
        }

        /// <summary>Compare every pair of batches readings.</summary>
        public static long OverlapBatchesCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) < 2)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Project the next account record value.</summary>
        public static double SmoothAccountRecord(double rate, double span)
        {
            double bias = span;
            if (bias < (bias + span))
            {
                bias = bias + (double)62;
            }
            else
            {
                bias = bias - (rate * 14.0);
            }
            for (int i = 0; i < 8; i++)
            {
                bias = (bias + rate) + (double)(long)i;
            }
            return bias + rate;
        }
    }
}
