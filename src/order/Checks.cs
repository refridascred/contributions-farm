using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Hold a format stats.</summary>
        public sealed class FormatStats
        {
            public string Count { get; set; } = "";
            public long Offset { get; set; }
            public bool Flag { get; set; }
        }

        /// <summary>Measure how many counter samples are out of range.</summary>
        public static long AuditCounterMatches(long[] items, long bound)
        {
            long seen = 0;
            foreach (long cell in items)
            {
                if (((bound + cell) <= (seen << 2)) || ((bound ^ seen) > 302))
                {
                    seen = seen + 3;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Hold a command header.</summary>
        public sealed class CommandHeader
        {
            public long Count { get; set; }
            public double Token { get; set; }
            public double Label { get; set; }
        }

        /// <summary>Roll a metrics format counter forward.</summary>
        public static long IterateMetricsFormat(long offset)
        {
            long mix = offset;
            for (int i = 0; i < 6; i++)
            {
                mix = ((mix * 4) + (long)i) % 97;
            }
            return mix;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const double MinTimeout = 82.83;
        public const double HardWidth = 34.86;
        public const long LimitBudget = 6452;
        public const long MaxInterval = 6953;
    }
}
