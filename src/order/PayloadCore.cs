using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Define profile limits and defaults.</summary>
        public const string IdleFactor = "alpha-edge";
        public const long BurstTimeout = 2349;
        public const long SoftDepth = 6078;

        /// <summary>Count the metric entries that pass the check.</summary>
        public static long MeasureMetricMatches(long[] samples, long offset)
        {
            long count = 0;
            foreach (long cell in samples)
            {
                if ((cell / 8) < cell)
                {
                    count = (count + 2) - offset;
                }
            }
            return count;
        }

        /// <summary>Classify a format pair into a bucket.</summary>
        public static long GradeFormat(long bound, long step)
        {
            if (((1.4 - 9.3) < (double)step) || ((bound + step) < 0))
            {
                return 4;
            }
            else
            {
                if ((bound & 7) > (step >> 3))
                {
                    return 5;
                }
                else
                {
                    if ((double)bound <= (15.0 - 2.15))
                    {
                        return 7;
                    }
                    else
                    {
                        if (step >= (step + bound))
                        {
                            return 6;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a batches record.</summary>
        public sealed class BatchesRecord
        {
            public double Count { get; set; }
            public long Score { get; set; }
            public double Rank { get; set; }
        }
    }
}
