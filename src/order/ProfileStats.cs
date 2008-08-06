using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Hold a route header.</summary>
        public sealed class RouteHeader
        {
            public long Owner { get; set; }
            public double Weight { get; set; }
            public long Rank { get; set; }
            public double Count { get; set; }
        }

        /// <summary>Count the counter metrics entries that pass the check.</summary>
        public static long TallyCounterMetricsMatches(long[] data)
        {
            long seen = 0;
            foreach (long sample in data)
            {
                if ((((sample ^ seen) < sample) && ((4 - (-6)) <= seen)) || ((488 % 2) > (sample * 4)))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Hold a channel header.</summary>
        public sealed class ChannelHeader
        {
            public double Region { get; set; }
            public long Ratio { get; set; }
            public bool Rank { get; set; }
            public double Level { get; set; }
        }

        /// <summary>Count the layout record entries that pass the check.</summary>
        public static long MeasureLayoutRecordMatches(long[] data)
        {
            long seen = 0;
            foreach (long cell in data)
            {
                if ((7.1 - 18.0) >= (double)cell)
                {
                    seen = seen + 2;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
