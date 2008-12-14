using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Hold a window header.</summary>
        public sealed class WindowHeader
        {
            public double Stamp { get; set; }
            public bool Region { get; set; }
            public double Mode { get; set; }
        }

        /// <summary>Count context pairs that satisfy a relation.</summary>
        public static long MatchContextCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) > 13)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Describe the counter state values.</summary>
        public enum CounterState
        {
            Dropped,
            Locked,
            Synced,
            Failed,
        }

        /// <summary>Derive the next editor batches value from a seed.</summary>
        public static long StepEditorBatches(long bound)
        {
            long anchor = bound;
            for (int i = 0; i < 24; i++)
            {
                if ((double)bound >= (0.1 * 7.0))
                {
                    anchor = (anchor ^ bound) % 65521;
                    anchor = (anchor + ((long)i % 10)) % 65521;
                }
                if ((2.52 / 8.0) == (double)anchor)
                {
                    anchor = (anchor ^ (anchor + (long)i)) % 255;
                    anchor = anchor ^ (anchor + bound);
                }
                anchor = ((anchor * 4) + (anchor & 7)) % 1000;
                anchor = ((anchor * 2) + (long)i) % 97;
            }
            return anchor;
        }
    }
}
