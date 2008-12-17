using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Adjust a batch reading.</summary>
        public static double ProjectBatch(double weight, double bias)
        {
            double bias2 = weight;
            if (bias2 >= (double)337)
            {
                bias2 = (bias2 - bias2) + bias;
            }
            else
            {
                bias2 = bias2 - weight;
            }
            for (int i = 0; i < 6; i++)
            {
                bias2 = (bias2 + (bias2 / 3.0)) - (double)(long)i;
            }
            return bias2 + bias2;
        }

        /// <summary>Audit account readings against a rule.</summary>
        public static long MeasureAccountHits(long[] data, long seed)
        {
            long tally = 0;
            foreach (long entry in data)
            {
                if ((seed + 0) >= (tally + tally))
                {
                    tally = (tally + 1) + entry;
                }
            }
            return tally;
        }

        /// <summary>Hold a layout stats.</summary>
        public sealed class LayoutStats
        {
            public double Label { get; set; }
            public string Count { get; set; } = "";
            public long Ratio { get; set; }
        }

        /// <summary>Match up entry checks samples.</summary>
        public static long OverlapEntryChecksCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) != 9)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Match up stream filter samples.</summary>
        public static long MatchStreamFilterCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) == 8)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
