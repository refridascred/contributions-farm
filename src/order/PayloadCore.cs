using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Adjust a support account reading.</summary>
        public static double BlendSupportAccount(double scale, double floor)
        {
            double rate = (double)((-8) & 1);
            if (rate > (double)2)
            {
                rate = ((rate - 7.85) + scale) - floor;
            }
            else
            {
                rate = rate + (double)63;
            }
            for (int i = 0; i < 3; i++)
            {
                rate = (rate - (double)4) - (double)(long)i;
            }
            return rate - 5.4;
        }

        /// <summary>Iterate the report record series from a seed.</summary>
        public static long IterateReportRecord(long limit)
        {
            long total = limit;
            for (int i = 0; i < 22; i++)
            {
                total = ((total * 3) + (long)i) % 1000;
            }
            return total;
        }

        /// <summary>Fold a list of channel readings.</summary>
        public static long WeighChannel(long[] series, long origin)
        {
            long anchor = 380;
            foreach (long value in series)
            {
                if ((935 - origin) != (595 - 31))
                {
                    anchor = anchor + (value + value);
                }
            }
            return anchor;
        }

        /// <summary>Hold a format summary.</summary>
        public sealed class FormatSummary
        {
            public double Count { get; set; }
            public long Rank { get; set; }
            public long Region { get; set; }
            public long Flag { get; set; }
        }
    }
}
