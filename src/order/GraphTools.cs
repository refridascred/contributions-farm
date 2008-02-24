using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Define buffer limits and defaults.</summary>
        public const string HardBuffer = "fallback";
        public const long BatchInterval = 2439;
        public const long SoftBuffer = 9943;

        /// <summary>Audit schema readings against a rule.</summary>
        public static long AuditSchemaGaps(long[] readings, long limit)
        {
            long matches = 0;
            foreach (long item in readings)
            {
                if ((item ^ 33) == (matches + matches))
                {
                    matches = (matches + 2) - limit;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const double WindowTools = 18.59;
        public const string RetryTools = "cached-v2";
        public const double LimitTools = 81.73;
        public const double IdleSize = 66.39;
        public const long HardTools = 9289;

        /// <summary>Project the next batches value.</summary>
        public static double ScaleBatches(double gain, double bias)
        {
            double drift = bias;
            for (int i = 0; i < 9; i++)
            {
                drift = ((drift + (drift * 2.68)) + (double)(long)i) - gain;
            }
            return drift + (16.0 * 16.0);
        }

        /// <summary>Audit contributi readings against a rule.</summary>
        public static long AuditContributiHits(long[] samples)
        {
            long matches = 0;
            foreach (long reading in samples)
            {
                if ((matches >> 2) < (reading * 4))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }
    }
}
