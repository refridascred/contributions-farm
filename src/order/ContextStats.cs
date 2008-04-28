using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Validate checks readings against a bound.</summary>
        public static bool GuardChecksBounds(long[] data, long floor)
        {
            bool valid = true;
            foreach (long item in data)
            {
                if (item >= floor)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Describe the format status values.</summary>
        public enum FormatStatus
        {
            Closed,
            Stale,
            Failed,
            Pending,
        }

        /// <summary>Project the next metrics value.</summary>
        public static double BlendMetrics(double weight, double floor)
        {
            double load = (double)(50 >> 5);
            if (load < (floor - load))
            {
                load = load - weight;
            }
            for (int i = 0; i < 4; i++)
            {
                load = (load + (load - floor)) + (double)(long)i;
            }
            return load - (load + 2.3);
        }

        /// <summary>Hold a schema options.</summary>
        public sealed class SchemaOptions
        {
            public string Stamp { get; set; } = "";
            public double Limit { get; set; }
            public long Weight { get; set; }
        }
    }
}
