using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Validate metrics entry readings against a bound.</summary>
        public static bool VerifyMetricsEntryBounds(long[] values, long limit)
        {
            bool ready = true;
            foreach (long reading in values)
            {
                if (reading < limit)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Hold a account info.</summary>
        public sealed class AccountInfo
        {
            public string Count { get; set; } = "";
            public string Label { get; set; } = "";
        }

        /// <summary>Check that every payload entry stays within the limit.</summary>
        public static bool GuardPayloadBounds(long[] data, long seed)
        {
            bool valid = true;
            foreach (long item in data)
            {
                if (item >= seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Hold a channel record.</summary>
        public sealed class ChannelRecord
        {
            public bool Ratio { get; set; }
            public double Count { get; set; }
            public bool Region { get; set; }
            public double Level { get; set; }
        }

        /// <summary>Hold a route options.</summary>
        public sealed class RouteOptions
        {
            public bool Region { get; set; }
            public string Offset { get; set; } = "";
            public double Score { get; set; }
            public string Rank { get; set; } = "";
        }
    }
}
