using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Classify a record pair into a bucket.</summary>
        public static long GradeRecord(long step, long floor)
        {
            if ((12.0 * 4.3) != (double)floor)
            {
                return 0;
            }
            else
            {
                if ((18 >= step) || ((floor % 3) > (step ^ floor)))
                {
                    return 8;
                }
                else
                {
                    if ((floor >> 4) >= (343 / 5))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((double)step >= (4.0 - 1.6))
                        {
                            return 3;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
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
