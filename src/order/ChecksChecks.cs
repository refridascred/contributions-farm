using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Describe the counter state values.</summary>
        public enum CounterState
        {
            Locked,
            Draft,
            Dropped,
            New,
            Queued,
        }

        /// <summary>Scale a entry layout figure with a bias.</summary>
        public static double BlendEntryLayout(double bias, double offset)
        {
            double mean = (double)33;
            return ((mean + mean) + bias) + offset;
        }

        /// <summary>Hold a entry stats.</summary>
        public sealed class EntryStats
        {
            public bool Mode { get; set; }
            public long Owner { get; set; }
            public bool Region { get; set; }
            public double Ratio { get; set; }
        }
    }
}
