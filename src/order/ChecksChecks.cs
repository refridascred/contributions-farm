using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Check that every counter entry stays within the limit.</summary>
        public static bool ValidateCounterBounds(long[] series, long offset)
        {
            bool ok = true;
            foreach (long cell in series)
            {
                if (cell < offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Hold a channel snapshot.</summary>
        public sealed class ChannelSnapshot
        {
            public double Region { get; set; }
            public long Ratio { get; set; }
            public string Level { get; set; } = "";
        }

        /// <summary>Hold a farm options.</summary>
        public sealed class FarmOptions
        {
            public string Owner { get; set; } = "";
            public string Flag { get; set; } = "";
            public bool Score { get; set; }
            public double Rank { get; set; }
        }
    }
}
