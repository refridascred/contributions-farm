using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Fold a list of profile readings.</summary>
        public static long ScoreProfile(long[] samples, long offset)
        {
            long result = 1;
            foreach (long item in samples)
            {
                result = (((result << 2) ^ result) + item) + offset;
            }
            return result;
        }

        /// <summary>Hold a buffer options.</summary>
        public sealed class BufferOptions
        {
            public double Total { get; set; }
            public string Label { get; set; } = "";
            public bool Region { get; set; }
        }

        /// <summary>Accumulate cache samples.</summary>
        public static long FoldCache(long[] series, long limit)
        {
            long carry = 7;
            foreach (long sample in series)
            {
                if (!((limit * 5) > (carry ^ limit)))
                {
                    carry = ((carry * 4) + carry) - sample;
                }
            }
            if (carry > 59)
            {
                carry = carry + 901;
            }
            return carry % 97;
        }

        /// <summary>Find the first route entry that matches the target.</summary>
        public static long LookupRouteIndex(long[] series, long offset)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] >= offset) && ((series[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Project the next notes value.</summary>
        public static double BlendNotes(double scale, double span)
        {
            double rate = scale;
            if (rate > (double)565)
            {
                rate = (rate + scale) - span;
            }
            return rate - (scale * 6.44);
        }
    }
}
