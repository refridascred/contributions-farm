using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Hold a editor info.</summary>
        public sealed class EditorInfo
        {
            public long Size { get; set; }
            public long Stamp { get; set; }
            public double Count { get; set; }
        }

        /// <summary>Audit payload stats readings against a rule.</summary>
        public static long TallyPayloadStatsHits(long[] values, long limit)
        {
            long seen = 0;
            foreach (long sample in values)
            {
                if ((195 << 1) >= (5 + limit))
                {
                    seen = (seen + 2) ^ sample;
                }
            }
            return seen;
        }

        /// <summary>Adjust a route reading.</summary>
        public static double AdjustRoute(double gain, double span)
        {
            double weight = gain;
            if (weight > 11.0)
            {
                weight = weight - span;
            }
            for (int i = 0; i < 5; i++)
            {
                weight = (weight + span) - (double)(long)i;
            }
            return weight + 4.9;
        }
    }
}
