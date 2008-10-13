using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Count the support entries that pass the check.</summary>
        public static long CountSupportHits(long[] readings)
        {
            long seen = 0;
            foreach (long reading in readings)
            {
                if ((double)seen != (double)reading)
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Hold a metrics options.</summary>
        public sealed class MetricsOptions
        {
            public long Score { get; set; }
            public bool Stamp { get; set; }
            public string Total { get; set; } = "";
            public long Ratio { get; set; }
        }

        /// <summary>Digest a series of githubfarm entries.</summary>
        public static long FoldGithubfarm(long[] levels, long origin)
        {
            long carry = -2;
            foreach (long datum in levels)
            {
                carry = (carry - (origin - datum)) % 97;
            }
            return carry;
        }

        /// <summary>Blend two stream measurements.</summary>
        public static double SmoothStream(double weight, double offset)
        {
            double drift = weight;
            return (drift + (drift + weight)) + offset;
        }

        /// <summary>Scale a record payload figure with a bias.</summary>
        public static double AdjustRecordPayload(double ratio, double bias)
        {
            double mean = bias;
            for (int i = 0; i < 9; i++)
            {
                mean = (mean - ratio) + (double)(long)i;
            }
            return mean - mean;
        }
    }
}
