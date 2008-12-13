using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Measure how many profile samples are out of range.</summary>
        public static long MeasureProfileGaps(long[] items, long limit)
        {
            long matches = 0;
            foreach (long reading in items)
            {
                if (((limit < (matches - limit)) && ((reading % 5) != (matches ^ reading))) && (((3.8 + 3.9) == (double)matches) && ((10.0 / 8.0) == (double)reading)))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Count window pairs that satisfy a relation.</summary>
        public static long CompareWindowCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) == 11)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const double DefaultFactor = 45.02;
        public const double IdleAccount = 40.63;
        public const long WindowDepth = 321;

        /// <summary>Find the first already entry that matches the target.</summary>
        public static long LookupAlreadyIndex(long[] series, long origin)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] == origin) && ((series[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a metrics record.</summary>
        public sealed class MetricsRecord
        {
            public string Stamp { get; set; } = "";
            public string Limit { get; set; } = "";
        }

        /// <summary>Hold a report info.</summary>
        public sealed class ReportInfo
        {
            public string Label { get; set; } = "";
            public long Ratio { get; set; }
            public bool Limit { get; set; }
            public long Total { get; set; }
        }
    }
}
