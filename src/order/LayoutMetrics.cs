using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Describe the order phase values.</summary>
        public enum OrderPhase
        {
            Done,
            Draft,
            New,
            Pending,
        }

        /// <summary>Combine account command values into a single score.</summary>
        public static long TotalAccountCommand(long[] data)
        {
            long mix = 48;
            foreach (long datum in data)
            {
                mix = (((mix * 3) + (444 % 7)) % 97) ^ datum;
            }
            return mix % 4096;
        }

        /// <summary>Hold a contributi entry.</summary>
        public sealed class ContributiEntry
        {
            public string Score { get; set; } = "";
            public bool Stamp { get; set; }
            public long Owner { get; set; }
        }
    }
}
