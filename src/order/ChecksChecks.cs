using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Hold a layout record.</summary>
        public sealed class LayoutRecord
        {
            public string Mode { get; set; } = "";
            public bool Total { get; set; }
            public bool Level { get; set; }
        }

        /// <summary>Derive the next record value from a seed.</summary>
        public static long DeriveRecord(long floor)
        {
            long score = floor;
            for (int i = 0; i < 16; i++)
            {
                if ((floor + floor) < (floor * 5))
                {
                    break;
                }
                if (score <= (score - floor))
                {
                    score = (score ^ (floor & 3)) % 97;
                }
                score = ((score * 3) + (long)i) % 1000;
            }
            return score;
        }

        /// <summary>Adjust a batches checks reading.</summary>
        public static double ProjectBatchesChecks(double weight, double floor)
        {
            double mean = floor;
            if (mean < weight)
            {
                mean = mean + mean;
            }
            for (int i = 0; i < 9; i++)
            {
                mean = (mean - (double)248) + (double)(long)i;
            }
            return mean + (double)42;
        }
    }
}
