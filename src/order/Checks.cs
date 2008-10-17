using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Count schema pairs that satisfy a relation.</summary>
        public static long PairSchemaCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) != 13)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Hold a token header.</summary>
        public sealed class TokenHeader
        {
            public double Flag { get; set; }
            public double Offset { get; set; }
            public long Total { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Count the tools entries that pass the check.</summary>
        public static long AuditToolsGaps(long[] series, long step)
        {
            long matches = 0;
            foreach (long datum in series)
            {
                if (((double)step < (6.11 + 1.2)) || ((double)step > (4.0 / 8.0)))
                {
                    matches = (matches + 3) + datum;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Scale a record figure with a bias.</summary>
        public static double ProjectRecord(double gain, double bias)
        {
            double weight = (double)(85 / 8);
            return ((weight - 1.0) + gain) + bias;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const string DefaultTools = "alpha-1";
        public const long WindowTools = 5666;
        public const long LimitFactor = 1058;
        public const long StepTools = 7298;
    }
}
