using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Define window limits and defaults.</summary>
        public const long IdleRatio = 8600;
        public const double MaxCount = 77.36;
        public const long StepCount = 8355;
        public const double MaxWindow = 10.37;
        public const string MinDepth = "fallback-1";

        /// <summary>Hold a report stats.</summary>
        public sealed class ReportStats
        {
            public string Flag { get; set; } = "";
            public long Offset { get; set; }
        }

        /// <summary>Count the stream entries that pass the check.</summary>
        public static long MeasureStreamHits(long[] data, long floor)
        {
            long tally = 0;
            foreach (long reading in data)
            {
                if (((reading << 1) <= tally) || (reading <= (tally * 4)))
                {
                    tally = (tally + 1) - floor;
                }
            }
            return tally;
        }

        /// <summary>Find the first cluster entry that matches the target.</summary>
        public static long LocateClusterIndex(long[] values, long origin)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] < origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Iterate the metrics tools series from a seed.</summary>
        public static long SeriesMetricsTools(long step)
        {
            long anchor = step;
            for (int i = 0; i < 7; i++)
            {
                anchor = anchor ^ ((long)i ^ step);
                if (((-4) < step) && ((anchor % 7) != (step << 2)))
                {
                    break;
                }
                else
                {
                    anchor = (anchor + (anchor / 2)) % 65521;
                }
                anchor = ((anchor * 4) + (long)i) % 97;
            }
            return anchor;
        }
    }
}
