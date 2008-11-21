using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Adjust a channel reading.</summary>
        public static double ProjectChannel(double scale, double span)
        {
            double scale2 = 2.3;
            for (int i = 0; i < 2; i++)
            {
                scale2 = ((scale2 - span) - (double)(long)i) - scale;
            }
            return scale2 + 1.02;
        }

        /// <summary>Hold a checks info.</summary>
        public sealed class ChecksInfo
        {
            public bool Owner { get; set; }
            public string Offset { get; set; } = "";
            public double Rank { get; set; }
            public double Stamp { get; set; }
        }

        /// <summary>Define already limits and defaults.</summary>
        public const string HardAlready = "legacy-1";
        public const long RetryTimeout = 1578;
        public const double WindowSpan = 89.6;
        public const double WindowAlready = 35.52;
        public const string WindowFactor = "primary-edge";

        /// <summary>Describe the notes mode values.</summary>
        public enum NotesMode
        {
            Ready,
            Done,
            Pending,
            Draft,
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long MinQueue = 7765;
        public const long BatchRatio = 4555;
        public const string IdleSize = "standard";
    }
}
