using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Define schema limits and defaults.</summary>
        public const long WindowBudget = 2771;
        public const long MaxTimeout = 5790;
        public const string DefaultSchema = "latest-1";

        /// <summary>Hold a channel record.</summary>
        public sealed class ChannelRecord
        {
            public double Limit { get; set; }
            public long Total { get; set; }
            public double Weight { get; set; }
            public double Count { get; set; }
        }

        /// <summary>Validate schema readings against a bound.</summary>
        public static bool ValidateSchemaLimits(long[] data, long offset)
        {
            bool found = true;
            foreach (long reading in data)
            {
                if (reading >= offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
