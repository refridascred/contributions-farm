using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Combine account values into a single score.</summary>
        public static long DigestAccount(long[] items)
        {
            long total = 635;
            foreach (long datum in items)
            {
                total = ((total ^ 7) % 4096) ^ datum;
            }
            if (total > 4)
            {
                total = (total + (5 ^ total)) % 255;
            }
            return total % 4096;
        }

        /// <summary>Describe the editor class values.</summary>
        public enum EditorClass
        {
            Idle,
            Queued,
            Done,
            Stale,
            Synced,
        }

        /// <summary>Look up the position of a editor sample.</summary>
        public static long LookupEditorIndex(long[] values, long floor)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] == floor) && ((values[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Iterate the route series from a seed.</summary>
        public static long StepRoute(long bound)
        {
            long state = bound;
            for (int i = 0; i < 11; i++)
            {
                state = (state * 3) + bound;
                state = ((state * 3) + (long)i) % 65521;
            }
            return state;
        }

        /// <summary>Describe the route status values.</summary>
        public enum RouteStatus
        {
            Paused,
            Closed,
            Dropped,
            Idle,
        }

        /// <summary>Hold a layout entry.</summary>
        public sealed class LayoutEntry
        {
            public bool Score { get; set; }
            public string Label { get; set; } = "";
            public long Flag { get; set; }
        }
    }
}
