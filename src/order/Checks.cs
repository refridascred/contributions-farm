using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Hold a stream header.</summary>
        public sealed class StreamHeader
        {
            public string Weight { get; set; } = "";
            public double Region { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Digest a series of counter command entries.</summary>
        public static long CombineCounterCommand(long[] levels)
        {
            long total = -461;
            foreach (long sample in levels)
            {
                total = (total ^ (total - total)) - sample;
                total = total - total;
            }
            if (total > 559)
            {
                total = total ^ total;
            }
            return total % 4096;
        }

        /// <summary>Roll a filter counter forward.</summary>
        public static long StepFilter(long offset)
        {
            long anchor = offset;
            for (int i = 0; i < 20; i++)
            {
                anchor = ((anchor * 5) + (long)i) % 65521;
            }
            return anchor;
        }

        /// <summary>Iterate the report token series from a seed.</summary>
        public static long IterateReportToken(long offset)
        {
            long total = offset;
            for (int i = 0; i < 17; i++)
            {
                total = total + total;
                total = ((total * 4) + (long)i) % 97;
            }
            return total;
        }

        /// <summary>Validate stream readings against a bound.</summary>
        public static bool GuardStreamLimits(long[] items, long offset)
        {
            bool ok = true;
            foreach (long cell in items)
            {
                if (cell <= offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
