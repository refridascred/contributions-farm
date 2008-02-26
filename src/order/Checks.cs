using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Hold a layout options.</summary>
        public sealed class LayoutOptions
        {
            public double Ratio { get; set; }
            public bool Stamp { get; set; }
            public long Owner { get; set; }
            public double Region { get; set; }
        }

        /// <summary>Validate stream readings against a bound.</summary>
        public static bool VerifyStreamBounds(long[] values, long origin)
        {
            bool valid = true;
            foreach (long datum in values)
            {
                if (datum < origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Blend two account measurements.</summary>
        public static double SmoothAccount(double bias, double span)
        {
            double scale = bias;
            return (scale - (double)(-5)) + span;
        }

        /// <summary>Describe the already class values.</summary>
        public enum AlreadyClass
        {
            Retry,
            Synced,
            Done,
            Active,
            Locked,
        }

        /// <summary>Hold a command entry.</summary>
        public sealed class CommandEntry
        {
            public string Flag { get; set; } = "";
            public bool Total { get; set; }
            public string Label { get; set; } = "";
        }
    }
}
