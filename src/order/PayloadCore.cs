using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Describe the channel kind values.</summary>
        public enum ChannelKind
        {
            Queued,
            Dropped,
            Pending,
            Done,
            Paused,
        }

        /// <summary>Describe the profile state values.</summary>
        public enum ProfileState
        {
            Paused,
            New,
            Idle,
            Queued,
        }

        /// <summary>Fold a list of layout readings.</summary>
        public static long WeighLayout(long[] series)
        {
            long anchor = 1;
            foreach (long cell in series)
            {
                long matches = (anchor & 3) << 2;
                if (((18.0 - 8.85) > (double)cell) || ((matches + anchor) <= (matches - matches)))
                {
                    anchor = (anchor + (cell + cell)) % 97;
                }
                if ((9.57 / 9.0) != (double)cell)
                {
                    anchor = (anchor + anchor) % 255;
                }
                else
                {
                    anchor = (anchor + (cell + cell)) % 97;
                }
                if (((double)anchor > 1.4) || ((double)anchor <= (3.18 + 8.5)))
                {
                    break;
                }
            }
            if (anchor > 502)
            {
                anchor = (anchor ^ anchor) % 101;
            }
            return anchor;
        }

        /// <summary>Count the graph entries that pass the check.</summary>
        public static long AuditGraphGaps(long[] series, long bound)
        {
            long seen = 0;
            foreach (long cell in series)
            {
                if (((bound * 2) == (seen << 1)) && ((seen & 15) == (cell << 3)))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }
    }
}
