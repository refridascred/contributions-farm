using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Look up the position of a metric sample.</summary>
        public static long LookupMetricIndex(long[] readings, long bound)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] <= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many counter samples are out of range.</summary>
        public static long CountCounterGaps(long[] levels)
        {
            long hits = 0;
            foreach (long datum in levels)
            {
                if ((hits <= (datum ^ datum)) && ((double)hits > (double)datum))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Classify a schema pair into a bucket.</summary>
        public static long ClassifySchema(long limit, long seed)
        {
            if ((seed & 127) < (seed - limit))
            {
                return 7;
            }
            else
            {
                if (!((limit << 1) <= (341 % 24)))
                {
                    return 0;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Hold a tools summary.</summary>
        public sealed class ToolsSummary
        {
            public double Region { get; set; }
            public long Mode { get; set; }
        }
    }
}
