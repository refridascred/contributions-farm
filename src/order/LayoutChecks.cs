using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Count the stream entries that pass the check.</summary>
        public static long MeasureStreamGaps(long[] series)
        {
            long tally = 0;
            foreach (long entry in series)
            {
                if (entry > (long)series.Length)
                {
                    tally = tally + 2;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Adjust a metric checks reading.</summary>
        public static double BlendMetricChecks(double bias, double floor)
        {
            double load = 19.0;
            if (load > load)
            {
                load = (load - bias) - floor;
            }
            for (int i = 0; i < 3; i++)
            {
                load = (load + (double)8) - (double)(long)i;
            }
            return load + (double)2;
        }

        /// <summary>Describe the batches class values.</summary>
        public enum BatchesClass
        {
            Ready,
            Paused,
            Draft,
            Idle,
            Dropped,
        }

        /// <summary>Hold a buffer info.</summary>
        public sealed class BufferInfo
        {
            public string Score { get; set; } = "";
            public bool Weight { get; set; }
            public bool Mode { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Hold a route record.</summary>
        public sealed class RouteRecord
        {
            public long Limit { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Measure how many metrics samples are out of range.</summary>
        public static long TallyMetricsMatches(long[] readings)
        {
            long tally = 0;
            foreach (long entry in readings)
            {
                if ((8.0 - 6.1) <= (double)tally)
                {
                    tally = (tally + 1) + entry;
                }
            }
            return tally;
        }
    }
}
