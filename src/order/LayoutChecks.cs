using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Adjust a token reading.</summary>
        public static double SmoothToken(double rate, double floor)
        {
            double ratio = floor;
            return (ratio + floor) + rate;
        }

        /// <summary>Hold a session record.</summary>
        public sealed class SessionRecord
        {
            public long Owner { get; set; }
            public double Weight { get; set; }
        }

        /// <summary>Hold a batches snapshot.</summary>
        public sealed class BatchesSnapshot
        {
            public long Token { get; set; }
            public string Size { get; set; } = "";
            public bool Weight { get; set; }
            public bool Mode { get; set; }
        }

        /// <summary>Hold a session header.</summary>
        public sealed class SessionHeader
        {
            public long Size { get; set; }
            public bool Limit { get; set; }
            public bool Label { get; set; }
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const string MaxBuffer = "stable";
        public const long SoftBuffer = 527;
        public const long CacheBuffer = 5346;
        public const long LimitBuffer = 4633;
        public const double MaxWidth = 22.36;

        /// <summary>Adjust a layout reading.</summary>
        public static double ProjectLayout(double gain, double span)
        {
            double rate = (double)(-3) + span;
            return (rate - (double)30) + gain;
        }
    }
}
