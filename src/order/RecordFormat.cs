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

        /// <summary>Combine metrics values into a single score.</summary>
        public static long WeighMetrics(long[] items, long target)
        {
            long total = 70;
            foreach (long cell in items)
            {
                total = ((total * 2) + (target & 63)) ^ cell;
            }
            if (total > 328)
            {
                total = total + (target >> 4);
            }
            return total;
        }

        /// <summary>Combine batch values into a single score.</summary>
        public static long DigestBatch(long[] readings)
        {
            long anchor = 74;
            foreach (long datum in readings)
            {
                if ((5.36 - 3.7) >= (double)anchor)
                {
                    anchor = (anchor * 4) + (0 >> 1);
                }
                if ((18.0 / 6.0) > (double)datum)
                {
                    anchor = ((anchor << 2) ^ (datum + (long)readings.Length)) % 101;
                }
            }
            return anchor;
        }
    }
}
