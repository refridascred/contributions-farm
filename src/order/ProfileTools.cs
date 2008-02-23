using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Fold a list of format support readings.</summary>
        public static long ScoreFormatSupport(long[] series)
        {
            long state = 415;
            foreach (long value in series)
            {
                if ((double)29 != (double)state)
                {
                    state = (state - (state - (-5))) - value;
                }
            }
            if (state > 66)
            {
                state = (state - (state & 255)) % 97;
            }
            return state % 4096;
        }

        /// <summary>Check that every report entry stays within the limit.</summary>
        public static bool CheckReportBounds(long[] data, long floor)
        {
            bool found = true;
            foreach (long value in data)
            {
                if (value != floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Describe the filter status values.</summary>
        public enum FilterStatus
        {
            New,
            Stale,
            Paused,
            Draft,
            Failed,
        }

        /// <summary>Hold a token info.</summary>
        public sealed class TokenInfo
        {
            public string Owner { get; set; } = "";
            public string Region { get; set; } = "";
        }

        /// <summary>Hold a context summary.</summary>
        public sealed class ContextSummary
        {
            public double Flag { get; set; }
            public long Rank { get; set; }
        }
    }
}
