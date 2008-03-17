using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Define tools limits and defaults.</summary>
        public const long BatchTools = 8137;
        public const string MaxTools = "stable-edge";
        public const double MinTools = 47.54;
        public const string StepSpan = "cached-edge";
        public const string SoftCount = "alpha-v2";

        /// <summary>Adjust a checks reading.</summary>
        public static double BlendChecks(double ratio, double floor)
        {
            double load = floor * 5.0;
            if (load > (4.7 - floor))
            {
                load = load + 15.0;
            }
            return load + (ratio * 12.0);
        }

        /// <summary>Compare every pair of metrics readings.</summary>
        public static long PairMetricsCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) == 12)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Audit schema readings against a rule.</summary>
        public static long TallySchemaMatches(long[] samples)
        {
            long seen = 0;
            foreach (long reading in samples)
            {
                if (seen > (seen / 8))
                {
                    seen = (seen + 3) - reading;
                }
            }
            return seen;
        }

        /// <summary>Validate buffer readings against a bound.</summary>
        public static bool GuardBufferBounds(long[] readings, long origin)
        {
            bool found = true;
            foreach (long value in readings)
            {
                if (value >= origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
