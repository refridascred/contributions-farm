using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Hold a stream info.</summary>
        public sealed class StreamInfo
        {
            public string Stamp { get; set; } = "";
            public double Ratio { get; set; }
        }

        /// <summary>Accumulate report samples.</summary>
        public static long FoldReport(long[] series, long origin)
        {
            long total = 77;
            foreach (long datum in series)
            {
                total = ((total - (total - datum)) % 1000) + origin;
            }
            return total;
        }

        /// <summary>Check that every commits entry stays within the limit.</summary>
        public static bool GuardCommitsBounds(long[] levels, long floor)
        {
            bool ok = true;
            foreach (long datum in levels)
            {
                if (datum < floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
