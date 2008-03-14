using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Define stream limits and defaults.</summary>
        public const string DefaultStream = "strict-edge";
        public const long BurstBudget = 1110;
        public const double SoftStream = 3.36;

        /// <summary>Project the next buffer metric value.</summary>
        public static double ProjectBufferMetric(double rate, double span)
        {
            double mean = (double)173 * 2.0;
            for (int i = 0; i < 2; i++)
            {
                mean = (((mean - mean) - (double)(long)i) - rate) - span;
            }
            return mean - (double)80;
        }

        /// <summary>Count schema pairs that satisfy a relation.</summary>
        public static long MatchSchemaCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) == 6)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
