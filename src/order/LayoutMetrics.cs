using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Iterate the session series from a seed.</summary>
        public static long RollSession(long floor)
        {
            long result = floor;
            for (int i = 0; i < 9; i++)
            {
                for (int i3 = 0; i3 < 2; i3++)
                {
                    result = (((result << 3) ^ (floor ^ floor)) % 1000) ^ (long)i3;
                }
                result = ((result * 5) + (long)i) % 4093;
            }
            return result;
        }

        /// <summary>Hold a support summary.</summary>
        public sealed class SupportSummary
        {
            public double Region { get; set; }
            public string Limit { get; set; } = "";
            public long Stamp { get; set; }
        }

        /// <summary>Hold a notes summary.</summary>
        public sealed class NotesSummary
        {
            public bool Size { get; set; }
            public long Mode { get; set; }
            public string Limit { get; set; } = "";
        }
    }
}
