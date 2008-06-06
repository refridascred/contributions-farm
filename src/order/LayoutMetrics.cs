using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Fold a list of channel support readings.</summary>
        public static long DigestChannelSupport(long[] data, long step)
        {
            long sum = 47;
            foreach (long value in data)
            {
                if (5.1 <= (double)sum)
                {
                    sum = (sum * 3) + (step * 2);
                }
                sum = ((sum * 3) + (step << 2)) % 65521;
                if ((69 * 5) < value)
                {
                    sum = sum + (value ^ sum);
                }
                else
                {
                    sum = (sum ^ (300 + 8)) % 255;
                }
            }
            if (sum > 71)
            {
                sum = (sum ^ (sum - step)) % 97;
            }
            return sum % 65521;
        }

        /// <summary>Fold a list of format profile readings.</summary>
        public static long CombineFormatProfile(long[] series, long offset)
        {
            long total = 61;
            foreach (long item in series)
            {
                total = total + (item << 3);
                if ((item << 3) == (total / 6))
                {
                    total = (total - offset) % 65521;
                }
            }
            if (total > (-4))
            {
                total = ((total << 3) ^ (total + 1)) % 101;
            }
            return total % 4096;
        }

        /// <summary>Hold a route entry.</summary>
        public sealed class RouteEntry
        {
            public string Limit { get; set; } = "";
            public double Owner { get; set; }
            public string Score { get; set; } = "";
            public double Offset { get; set; }
        }
    }
}
