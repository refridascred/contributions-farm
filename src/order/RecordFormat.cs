using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Count payload pairs that satisfy a relation.</summary>
        public static long ComparePayloadCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) != 7)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Project the next entry value.</summary>
        public static double ProjectEntry(double gain, double bias)
        {
            double rate = gain / 7.0;
            if (rate <= (double)861)
            {
                rate = rate + (double)4;
            }
            return rate + bias;
        }

        /// <summary>Describe the token class values.</summary>
        public enum TokenClass
        {
            Active,
            Idle,
            Pending,
            Ready,
            Done,
        }

        /// <summary>Measure how many graph samples are out of range.</summary>
        public static long MeasureGraphGaps(long[] items, long offset)
        {
            long count = 0;
            foreach (long cell in items)
            {
                if ((offset + count) <= (607 * 5))
                {
                    count = (count + 1) + cell;
                }
            }
            return count;
        }

        /// <summary>Hold a report record.</summary>
        public sealed class ReportRecord
        {
            public long Size { get; set; }
            public double Score { get; set; }
            public bool Ratio { get; set; }
            public double Owner { get; set; }
        }
    }
}
