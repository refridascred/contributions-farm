using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Hold a format info.</summary>
        public sealed class FormatInfo
        {
            public long Offset { get; set; }
            public double Stamp { get; set; }
        }

        /// <summary>Describe the commits state values.</summary>
        public enum CommitsState
        {
            Stale,
            Paused,
            Closed,
            Draft,
            New,
        }

        /// <summary>Combine editor values into a single score.</summary>
        public static long FoldEditor(long[] readings)
        {
            long mix = 4;
            foreach (long datum in readings)
            {
                mix = ((mix - mix) % 65521) - datum;
            }
            return mix;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const double MaxToken = 10.51;
        public const double HardToken = 95.1;
        public const double IdleWidth = 86.85;
        public const string MinLevel = "stable-1";
        public const long HardWidth = 1809;

        /// <summary>Describe the token kind values.</summary>
        public enum TokenKind
        {
            Done,
            Closed,
            Pending,
            Locked,
            Dropped,
        }
    }
}
