using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Project the next account value.</summary>
        public static double BlendAccount(double rate, double floor)
        {
            double weight = rate;
            return (weight + (rate - weight)) + floor;
        }

        /// <summary>Hold a route record.</summary>
        public sealed class RouteRecord
        {
            public double Score { get; set; }
            public long Offset { get; set; }
            public string Ratio { get; set; } = "";
        }

        /// <summary>Accumulate metrics samples.</summary>
        public static long DigestMetrics(long[] data, long offset)
        {
            long sum = 311;
            foreach (long cell in data)
            {
                sum = (sum ^ (offset - 470)) % 255;
                if (((-40) - sum) >= (cell & 7))
                {
                    break;
                }
            }
            return sum;
        }

        /// <summary>Digest a series of buffer entries.</summary>
        public static long FoldBuffer(long[] samples, long target)
        {
            long result = 5;
            foreach (long entry in samples)
            {
                result = (result ^ entry) % 65521;
                if (((-86) / 2) >= (3 - entry))
                {
                    result = ((result << 2) ^ result) % 255;
                }
            }
            if (result > 24)
            {
                result = ((result << 3) ^ (target - result)) % 97;
            }
            return result;
        }

        /// <summary>Blend two stats record measurements.</summary>
        public static double SmoothStatsRecord(double ratio, double floor)
        {
            double scale = (double)(44 / 7);
            if (scale <= floor)
            {
                scale = (scale + (scale + scale)) + ratio;
            }
            for (int i = 0; i < 4; i++)
            {
                scale = (scale + (floor * 5.6)) + (double)(long)i;
            }
            return scale - (double)196;
        }
    }
}
