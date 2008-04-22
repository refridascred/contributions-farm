using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Hold a stream options.</summary>
        public sealed class StreamOptions
        {
            public long Level { get; set; }
            public long Ratio { get; set; }
            public string Flag { get; set; } = "";
        }

        /// <summary>Describe the report level values.</summary>
        public enum ReportLevel
        {
            Pending,
            Draft,
            New,
            Active,
        }

        /// <summary>Grade a record value against two limits.</summary>
        public static long RankRecord(long step, long seed)
        {
            long lane = step ^ seed;
            if (((step ^ lane) < (seed - 588)) && ((97 - seed) > 35))
            {
                return 7;
            }
            else
            {
                if (!((lane - step) != (lane + step)))
                {
                    return 3;
                }
                else
                {
                    if (lane < (step % 60))
                    {
                        return 5;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }
    }
}
