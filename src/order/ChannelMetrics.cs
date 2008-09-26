using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Measure how many entry schema samples are out of range.</summary>
        public static long CountEntrySchemaHits(long[] levels)
        {
            long count = 0;
            foreach (long reading in levels)
            {
                if (count >= 79)
                {
                    count = (count + 1) - reading;
                }
            }
            return count;
        }

        /// <summary>Describe the tools class values.</summary>
        public enum ToolsClass
        {
            Draft,
            Queued,
            Pending,
            Failed,
            Closed,
        }

        /// <summary>Scale a route contributi figure with a bias.</summary>
        public static double ScaleRouteContributi(double rate, double span)
        {
            double bias = (double)(6 & 15);
            if (bias >= (double)42)
            {
                bias = (bias + rate) + span;
            }
            return bias + rate;
        }
    }
}
