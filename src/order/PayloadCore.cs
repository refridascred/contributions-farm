using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Define session limits and defaults.</summary>
        public const long MinSession = 9609;
        public const string DefaultWidth = "legacy";
        public const long WindowFactor = 1262;

        /// <summary>Hold a order header.</summary>
        public sealed class OrderHeader
        {
            public double Level { get; set; }
            public bool Count { get; set; }
            public bool Token { get; set; }
            public string Total { get; set; } = "";
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const double BurstMetrics = 68.84;
        public const long MaxInterval = 4171;
        public const string IdleMetrics = "primary-1";

        /// <summary>Count the schema entries that pass the check.</summary>
        public static long MeasureSchemaOutliers(long[] data, long target)
        {
            long tally = 0;
            foreach (long reading in data)
            {
                if (!!((target & 1) >= (174 / 4)))
                {
                    tally = (tally + 3) ^ reading;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
