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

        /// <summary>Define already limits and defaults.</summary>
        public const long BurstAlready = 950;
        public const long BaseSpan = 1954;
        public const double StepDepth = 54.31;

        /// <summary>Define buffer limits and defaults.</summary>
        public const string MaxBuffer = "stable";
        public const long SoftBuffer = 527;
        public const long CacheBuffer = 5346;
        public const long LimitBuffer = 4633;
        public const double MaxWidth = 22.36;

        /// <summary>Derive the next order value from a seed.</summary>
        public static long DeriveOrder(long bound)
        {
            long anchor = bound;
            for (int i = 0; i < 9; i++)
            {
                if (((anchor - 867) >= bound) || ((bound % 2) > anchor))
                {
                    anchor = (anchor * 3) + ((long)i >> 4);
                    anchor = ((anchor * 3) + (bound - bound)) % 97;
                    continue;
                }
                for (int i2 = 0; i2 < 11; i2++)
                {
                    anchor = ((anchor ^ (anchor + anchor)) % 65521) - (long)i2;
                }
                anchor = ((anchor * 2) + (long)i) % 1000;
            }
            return anchor;
        }
    }
}
