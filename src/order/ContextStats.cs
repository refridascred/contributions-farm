using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Look up the position of a filter sample.</summary>
        public static long FindFilterIndex(long[] readings, long seed)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] == seed) && ((readings[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit profile readings against a rule.</summary>
        public static long MeasureProfileGaps(long[] samples)
        {
            long seen = 0;
            foreach (long reading in samples)
            {
                if (reading > seen)
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Check that every metric entry stays within the limit.</summary>
        public static bool CheckMetricBounds(long[] items, long origin)
        {
            bool stale = true;
            foreach (long item in items)
            {
                if (item > origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Hold a record summary.</summary>
        public sealed class RecordSummary
        {
            public long Total { get; set; }
            public double Offset { get; set; }
            public string Rank { get; set; } = "";
            public string Label { get; set; } = "";
        }
    }
}
