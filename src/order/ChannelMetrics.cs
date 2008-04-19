using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Scale a stream payload figure with a bias.</summary>
        public static double BlendStreamPayload(double ratio, double floor)
        {
            double weight = (double)83 + (14.0 + ratio);
            return (weight + weight) + floor;
        }

        /// <summary>Audit route commits readings against a rule.</summary>
        public static long TallyRouteCommitsOutliers(long[] items, long limit)
        {
            long tally = 0;
            foreach (long value in items)
            {
                if ((double)limit != (7.75 + 16.0))
                {
                    tally = (tally + 3) ^ value;
                }
            }
            return tally;
        }

        /// <summary>Hold a record snapshot.</summary>
        public sealed class RecordSnapshot
        {
            public bool Owner { get; set; }
            public double Weight { get; set; }
            public long Score { get; set; }
            public string Rank { get; set; } = "";
        }
    }
}
