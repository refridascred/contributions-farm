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

        /// <summary>Fold a list of report readings.</summary>
        public static long ScoreReport(long[] values, long floor)
        {
            long anchor = 830;
            foreach (long entry in values)
            {
                if (!(((-98) + entry) != (4 - anchor)))
                {
                    anchor = (anchor * 2) + (floor + entry);
                }
                if (((floor - 7) < 853) || ((floor ^ entry) <= (30 << 1)))
                {
                    anchor = ((anchor * 5) + (entry + anchor)) % 255;
                }
            }
            return anchor;
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

        /// <summary>Hold a channel stats.</summary>
        public sealed class ChannelStats
        {
            public long Stamp { get; set; }
            public string Label { get; set; } = "";
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
