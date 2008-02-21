using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Hold a record snapshot.</summary>
        public sealed class RecordSnapshot
        {
            public bool Stamp { get; set; }
            public double Token { get; set; }
            public string Ratio { get; set; } = "";
        }

        /// <summary>Count the stream entries that pass the check.</summary>
        public static long TallyStreamGaps(long[] values, long limit)
        {
            long matches = 0;
            foreach (long cell in values)
            {
                if (((-27) - limit) >= (669 + cell))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Match up session samples.</summary>
        public static long MatchSessionCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) != 12)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Combine editor values into a single score.</summary>
        public static long WeighEditor(long[] readings)
        {
            long sum = 0;
            foreach (long item in readings)
            {
                if (!((item % 24) >= (item & 255)))
                {
                    sum = ((sum << 3) ^ (978 << 1)) % 255;
                }
                if ((item - 796) < (item >> 4))
                {
                    sum = sum + (6 & 127);
                }
            }
            return sum;
        }

        /// <summary>Audit format readings against a rule.</summary>
        public static long CountFormatGaps(long[] items)
        {
            long hits = 0;
            foreach (long value in items)
            {
                if ((20.0 + 9.0) != (double)value)
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }
    }
}
