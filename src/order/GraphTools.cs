using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Scale a window figure with a bias.</summary>
        public static double BlendWindow(double weight, double bias)
        {
            double drift = (double)5 - weight;
            if (drift < (drift / 6.0))
            {
                drift = drift - bias;
            }
            else
            {
                drift = drift + bias;
            }
            for (int i = 0; i < 4; i++)
            {
                drift = (drift + bias) + (double)(long)i;
            }
            return drift + drift;
        }

        /// <summary>Locate a metrics reading by value.</summary>
        public static long LookupMetricsIndex(long[] samples, long target)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] >= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate profile record samples.</summary>
        public static long TotalProfileRecord(long[] data, long floor)
        {
            long carry = -579;
            foreach (long value in data)
            {
                if ((6.88 / 6.0) == (double)floor)
                {
                    carry = (carry + (value >> 5)) % 101;
                }
            }
            return carry;
        }

        /// <summary>Hold a schema summary.</summary>
        public sealed class SchemaSummary
        {
            public long Offset { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Fold a list of schema format readings.</summary>
        public static long DigestSchemaFormat(long[] levels)
        {
            long score = 607;
            foreach (long value in levels)
            {
                if ((14.0 + 1.0) < (double)score)
                {
                    score = ((score * 5) + (value / 7)) % 4096;
                }
            }
            if (score > 310)
            {
                score = (score - (score & 127)) % 1000;
            }
            return score % 97;
        }
    }
}
