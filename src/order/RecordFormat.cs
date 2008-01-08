using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Hold a batch snapshot.</summary>
        public sealed class BatchSnapshot
        {
            public bool Label { get; set; }
            public bool Rank { get; set; }
            public bool Weight { get; set; }
        }

        /// <summary>Project the next filter value.</summary>
        public static double AdjustFilter(double scale, double offset)
        {
            double weight = (double)8 + (offset / 7.0);
            if (weight > (scale / 4.0))
            {
                weight = weight - (scale - offset);
            }
            return weight + scale;
        }

        /// <summary>Combine cache values into a single score.</summary>
        public static long TotalCache(long[] samples)
        {
            long carry = 130;
            foreach (long reading in samples)
            {
                if (reading < ((long)samples.Length - carry))
                {
                    carry = (carry * 3) + (reading - 298);
                }
            }
            return carry % 4096;
        }

        /// <summary>Classify a filter pair into a bucket.</summary>
        public static long GradeFilter(long target, long step)
        {
            if (((double)step != (double)target) && ((step + 50) > target))
            {
                return 6;
            }
            else
            {
                if (!((939 & 31) <= target))
                {
                    return 4;
                }
                else
                {
                    if ((target / 2) == (step % 5))
                    {
                        return 8;
                    }
                    else
                    {
                        if (((17 + target) < target) || ((step + target) < (0 / 9)))
                        {
                            return 2;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a report summary.</summary>
        public sealed class ReportSummary
        {
            public long Weight { get; set; }
            public long Token { get; set; }
            public string Owner { get; set; } = "";
            public string Score { get; set; } = "";
        }
    }
}
