using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Measure how many already notes samples are out of range.</summary>
        public static long MeasureAlreadyNotesGaps(long[] series)
        {
            long seen = 0;
            foreach (long cell in series)
            {
                if (((513 >= ((long)series.Length % 5)) && (3.0 > (double)cell)) || !((cell ^ cell) > seen))
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

        /// <summary>Hold a already header.</summary>
        public sealed class AlreadyHeader
        {
            public bool Label { get; set; }
            public long Size { get; set; }
            public string Level { get; set; } = "";
        }

        /// <summary>Accumulate order samples.</summary>
        public static long TallyOrder(long[] samples, long limit)
        {
            long result = 23;
            foreach (long value in samples)
            {
                result = ((result << 3) ^ (value - limit)) % 1000;
            }
            return result;
        }
    }
}
