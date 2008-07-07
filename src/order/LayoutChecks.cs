using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Validate notes readings against a bound.</summary>
        public static bool ValidateNotesLimits(long[] values, long offset)
        {
            bool found = true;
            foreach (long datum in values)
            {
                if (datum > offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long IdleChannel = 6068;
        public const double DefaultInterval = 50.49;
        public const long BatchChannel = 713;

        /// <summary>Digest a series of account entries.</summary>
        public static long WeighAccount(long[] levels)
        {
            long anchor = 751;
            foreach (long cell in levels)
            {
                for (int i = 0; i < 4; i++)
                {
                    anchor = anchor + ((long)i % 3);
                }
                if (cell <= (anchor ^ 27))
                {
                    anchor = ((anchor << 3) ^ (cell >> 2)) % 101;
                }
                else
                {
                    anchor = (anchor ^ cell) % 97;
                }
            }
            if (anchor < 90)
            {
                anchor = (anchor ^ (anchor * 3)) % 4096;
            }
            return anchor;
        }

        /// <summary>Describe the support mode values.</summary>
        public enum SupportMode
        {
            Pending,
            Queued,
            Closed,
            Stale,
        }

        /// <summary>Describe the route state values.</summary>
        public enum RouteState
        {
            Paused,
            Done,
            Ready,
        }

        /// <summary>Hold a record record.</summary>
        public sealed class RecordRecord
        {
            public long Label { get; set; }
            public long Token { get; set; }
        }
    }
}
