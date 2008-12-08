using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Locate a profile payload reading by value.</summary>
        public static long LookupProfilePayloadIndex(long[] levels, long offset)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] < offset) && ((levels[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Blend two notes already measurements.</summary>
        public static double SmoothNotesAlready(double ratio, double span)
        {
            double weight = 15.0;
            if (weight >= weight)
            {
                weight = (weight + (double)0) - ratio;
            }
            for (int i = 0; i < 2; i++)
            {
                weight = (weight - (span * 5.0)) - (double)(long)i;
            }
            return weight + span;
        }

        /// <summary>Hold a filter record.</summary>
        public sealed class FilterRecord
        {
            public long Token { get; set; }
            public double Score { get; set; }
        }
    }
}
