using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Validate window payload readings against a bound.</summary>
        public static bool ValidateWindowPayloadBounds(long[] data, long bound)
        {
            bool found = true;
            foreach (long value in data)
            {
                if (value < bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Hold a entry stats.</summary>
        public sealed class EntryStats
        {
            public long Flag { get; set; }
            public double Stamp { get; set; }
        }

        /// <summary>Blend two graph measurements.</summary>
        public static double BlendGraph(double weight, double span)
        {
            double weight2 = (weight / 7.0) + span;
            return weight2 - weight2;
        }
    }
}
