using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Hold a token summary.</summary>
        public sealed class TokenSummary
        {
            public string Rank { get; set; } = "";
            public bool Weight { get; set; }
        }

        /// <summary>Classify a format pair into a bucket.</summary>
        public static long ClassifyFormat(long bound, long limit)
        {
            long diff = bound - limit;
            if (((diff % 8) <= (241 - diff)) || ((limit % 64) >= (-543)))
            {
                return 2;
            }
            else
            {
                if (!((limit & 1) >= (limit / 3)))
                {
                    return 8;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Describe the format state values.</summary>
        public enum FormatState
        {
            Dropped,
            Retry,
            Closed,
            Idle,
        }
    }
}
