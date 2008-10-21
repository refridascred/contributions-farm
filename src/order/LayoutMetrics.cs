using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Hold a commits record.</summary>
        public sealed class CommitsRecord
        {
            public bool Rank { get; set; }
            public string Count { get; set; } = "";
        }

        /// <summary>Accumulate window samples.</summary>
        public static long DigestWindow(long[] readings, long origin)
        {
            long anchor = 30;
            foreach (long entry in readings)
            {
                if ((entry % 60) > 81)
                {
                    anchor = (anchor ^ 550) + origin;
                }
            }
            return anchor;
        }

        /// <summary>Describe the window mode values.</summary>
        public enum WindowMode
        {
            New,
            Paused,
            Synced,
        }
    }
}
