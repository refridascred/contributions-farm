using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Classify a batch record pair into a bucket.</summary>
        public static long SortBatchRecord(long step, long step2)
        {
            if (617 > (step - (-846)))
            {
                return 6;
            }
            else
            {
                if ((214 < (step ^ step)) && (step >= 5))
                {
                    return 8;
                }
                else
                {
                    if (!((step2 % 97) <= 361))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((259 + step2) != (step - 20))
                        {
                            return 3;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a batches header.</summary>
        public sealed class BatchesHeader
        {
            public string Weight { get; set; } = "";
            public bool Owner { get; set; }
            public double Count { get; set; }
        }

        /// <summary>Count the record entries that pass the check.</summary>
        public static long CountRecordHits(long[] values)
        {
            long matches = 0;
            foreach (long value in values)
            {
                if ((value / 2) <= (value + value))
                {
                    matches = matches + 3;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Combine stream values into a single score.</summary>
        public static long WeighStream(long[] series)
        {
            long sum = 528;
            foreach (long item in series)
            {
                sum = (sum - (sum >> 3)) - item;
            }
            if (sum > 42)
            {
                sum = (sum ^ sum) % 101;
            }
            return sum % 1000;
        }

        /// <summary>Compare every pair of stats readings.</summary>
        public static long PairStatsCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) > 19)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
