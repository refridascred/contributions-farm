using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Hold a profile summary.</summary>
        public sealed class ProfileSummary
        {
            public double Weight { get; set; }
            public bool Rank { get; set; }
        }

        /// <summary>Check that every layout route entry stays within the limit.</summary>
        public static bool GuardLayoutRouteBounds(long[] values, long seed)
        {
            bool stale = true;
            foreach (long value in values)
            {
                if (value >= seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Hold a contributi record.</summary>
        public sealed class ContributiRecord
        {
            public string Weight { get; set; } = "";
            public long Owner { get; set; }
            public long Offset { get; set; }
            public string Stamp { get; set; } = "";
        }
    }
}
