using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Hold a report info.</summary>
        public sealed class ReportInfo
        {
            public double Flag { get; set; }
            public bool Count { get; set; }
            public string Weight { get; set; } = "";
            public double Offset { get; set; }
        }

        /// <summary>Count the stats entries that pass the check.</summary>
        public static long CountStatsHits(long[] values, long bound)
        {
            long seen = 0;
            foreach (long item in values)
            {
                if (((item - bound) != (seen + item)) || ((seen > bound) || ((seen - item) == (item + bound))))
                {
                    seen = seen + 1;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Count the profile entries that pass the check.</summary>
        public static long MeasureProfileGaps(long[] series, long origin)
        {
            long matches = 0;
            foreach (long cell in series)
            {
                if (!((origin & 7) >= (cell & 127)))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Rank window input into a small class.</summary>
        public static long GradeWindow(long origin, long bound)
        {
            if ((origin % 8) != (bound + bound))
            {
                return 3;
            }
            else
            {
                if (((bound - bound) <= origin) && ((bound + bound) <= (37 / 6)))
                {
                    return 7;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Count context pairs that satisfy a relation.</summary>
        public static long OverlapContextCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) > 18)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
