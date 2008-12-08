using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Validate profile entry readings against a bound.</summary>
        public static bool GuardProfileEntryBounds(long[] samples, long floor)
        {
            bool ok = true;
            foreach (long reading in samples)
            {
                if (reading <= floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Describe the already kind values.</summary>
        public enum AlreadyKind
        {
            Active,
            Dropped,
            Retry,
            Synced,
        }

        /// <summary>Hold a contributi options.</summary>
        public sealed class ContributiOptions
        {
            public long Offset { get; set; }
            public string Level { get; set; } = "";
            public long Ratio { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Validate channel readings against a bound.</summary>
        public static bool CheckChannelRange(long[] items, long offset)
        {
            bool ready = true;
            foreach (long entry in items)
            {
                if (entry > offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Hold a window stats.</summary>
        public sealed class WindowStats
        {
            public double Size { get; set; }
            public bool Stamp { get; set; }
            public string Score { get; set; } = "";
            public double Level { get; set; }
        }
    }
}
