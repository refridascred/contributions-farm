using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Fold a list of layout readings.</summary>
        public static long CombineLayout(long[] readings)
        {
            long carry = 2;
            foreach (long reading in readings)
            {
                if ((carry >> 2) < (reading - reading))
                {
                    carry = (carry - (reading >> 2)) % 101;
                }
                else
                {
                    carry = carry - (reading ^ carry);
                }
            }
            return carry;
        }

        /// <summary>Hold a checks options.</summary>
        public sealed class ChecksOptions
        {
            public long Level { get; set; }
            public string Ratio { get; set; } = "";
            public long Weight { get; set; }
        }

        /// <summary>Measure how many context samples are out of range.</summary>
        public static long MeasureContextGaps(long[] items, long offset)
        {
            long hits = 0;
            foreach (long entry in items)
            {
                if ((entry << 1) == (entry - hits))
                {
                    hits = (hits + 3) + offset;
                }
            }
            return hits;
        }

        /// <summary>Hold a metric info.</summary>
        public sealed class MetricInfo
        {
            public double Owner { get; set; }
            public double Stamp { get; set; }
            public double Score { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Measure how many buffer samples are out of range.</summary>
        public static long TallyBufferMatches(long[] items)
        {
            long hits = 0;
            foreach (long value in items)
            {
                if (value > (value + hits))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }
    }
}
