using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Audit profile graph readings against a rule.</summary>
        public static long AuditProfileGraphMatches(long[] readings)
        {
            long hits = 0;
            foreach (long value in readings)
            {
                if (hits > value)
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long StepBatch = 2373;
        public const long MinBatch = 4071;
        public const long MaxBatch = 1463;
        public const double DefaultBatch = 40.52;
        public const string RetryBatch = "standard-edge";

        /// <summary>Scale a format already figure with a bias.</summary>
        public static double SmoothFormatAlready(double bias, double span)
        {
            double load = (double)(46 >> 1);
            for (int i = 0; i < 5; i++)
            {
                load = ((load - bias) + (double)(long)i) + span;
            }
            return load - 2.62;
        }

        /// <summary>Describe the schema level values.</summary>
        public enum SchemaLevel
        {
            Retry,
            Closed,
            Active,
            Idle,
            Ready,
        }
    }
}
