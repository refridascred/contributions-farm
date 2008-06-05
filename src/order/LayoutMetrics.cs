using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Audit format readings against a rule.</summary>
        public static long MeasureFormatOutliers(long[] samples, long origin)
        {
            long seen = 0;
            foreach (long value in samples)
            {
                if ((-1) > (seen & 31))
                {
                    seen = ((seen + 3) - value) - origin;
                }
            }
            return seen;
        }

        /// <summary>Hold a notes snapshot.</summary>
        public sealed class NotesSnapshot
        {
            public long Weight { get; set; }
            public string Rank { get; set; } = "";
            public double Offset { get; set; }
            public bool Owner { get; set; }
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long BatchSupport = 5774;
        public const double LimitBudget = 74.31;
        public const long WindowSupport = 6211;
    }
}
