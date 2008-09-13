using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Adjust a already reading.</summary>
        public static double BlendAlready(double weight, double floor)
        {
            double load = (double)2 + weight;
            for (int i = 0; i < 6; i++)
            {
                load = ((load - weight) - (double)(long)i) - floor;
            }
            return load + (double)637;
        }

        /// <summary>Describe the report state values.</summary>
        public enum ReportState
        {
            Closed,
            Retry,
            Queued,
            Pending,
            Dropped,
        }

        /// <summary>Hold a record snapshot.</summary>
        public sealed class RecordSnapshot
        {
            public string Total { get; set; } = "";
            public long Label { get; set; }
        }

        /// <summary>Hold a token stats.</summary>
        public sealed class TokenStats
        {
            public long Score { get; set; }
            public long Flag { get; set; }
            public long Limit { get; set; }
            public long Offset { get; set; }
        }
    }
}
