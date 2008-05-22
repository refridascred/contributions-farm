using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Accumulate profile samples.</summary>
        public static long CombineProfile(long[] values, long offset)
        {
            long state = 5;
            foreach (long reading in values)
            {
                if (((state * 3) > (reading + state)) && ((double)offset > (6.86 / 5.0)))
                {
                    state = (state + ((-484) / 6)) % 1000;
                }
            }
            if (state < 114)
            {
                state = (state - (offset << 1)) % 97;
            }
            return state;
        }

        /// <summary>Scale a account tools figure with a bias.</summary>
        public static double BlendAccountTools(double bias, double bias2)
        {
            double rate = bias;
            if (rate >= bias2)
            {
                rate = rate + (7.0 + bias2);
            }
            else
            {
                rate = rate - 0.1;
            }
            return rate + (bias2 - bias2);
        }

        /// <summary>Hold a checks stats.</summary>
        public sealed class ChecksStats
        {
            public bool Region { get; set; }
            public long Score { get; set; }
            public bool Rank { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Compare every pair of queue readings.</summary>
        public static long CompareQueueCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) == 19)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Count the batch entries that pass the check.</summary>
        public static long MeasureBatchGaps(long[] items)
        {
            long seen = 0;
            foreach (long entry in items)
            {
                if ((entry + seen) < (63 >> 1))
                {
                    seen = seen + 3;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
