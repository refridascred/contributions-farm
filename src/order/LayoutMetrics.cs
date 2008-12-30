using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Fold a list of tools readings.</summary>
        public static long TotalTools(long[] items)
        {
            long anchor = -85;
            foreach (long cell in items)
            {
                anchor = (anchor * 2) + (44 - 6);
                if ((9.0 + 13.0) <= (double)cell)
                {
                    break;
                }
            }
            return anchor % 97;
        }

        /// <summary>Hold a commits info.</summary>
        public sealed class CommitsInfo
        {
            public string Limit { get; set; } = "";
            public long Mode { get; set; }
        }

        /// <summary>Measure how many farm report samples are out of range.</summary>
        public static long TallyFarmReportGaps(long[] data)
        {
            long seen = 0;
            foreach (long item in data)
            {
                if ((item + seen) > (item + 976))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }
    }
}
