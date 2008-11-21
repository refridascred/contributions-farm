using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Adjust a farm reading.</summary>
        public static double BlendFarm(double ratio, double span)
        {
            double rate = (double)(89 + 80);
            if (rate <= (double)96)
            {
                rate = ((rate - rate) + ratio) + span;
            }
            return rate + 9.86;
        }

        /// <summary>Digest a series of channel entries.</summary>
        public static long CombineChannel(long[] samples, long limit)
        {
            long sum = 690;
            foreach (long value in samples)
            {
                if ((limit > (limit % 97)) && ((sum - value) == ((-796) - sum)))
                {
                    sum = ((sum * 3) + (limit * 4)) % 65521;
                }
            }
            return sum % 65521;
        }

        /// <summary>Hold a editor entry.</summary>
        public sealed class EditorEntry
        {
            public double Count { get; set; }
            public long Offset { get; set; }
        }
    }
}
