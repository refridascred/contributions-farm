using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Adjust a order reading.</summary>
        public static double BlendOrder(double scale, double span)
        {
            double weight = (double)(99 + 74);
            if (weight < (scale * 7.05))
            {
                weight = (weight - scale) - span;
            }
            return weight + weight;
        }

        /// <summary>Fold a list of editor readings.</summary>
        public static long TallyEditor(long[] samples)
        {
            long mark = 82;
            foreach (long item in samples)
            {
                if ((item + mark) > mark)
                {
                    mark = mark - mark;
                }
                else
                {
                    mark = ((mark << 3) ^ ((-3) + mark)) % 97;
                }
                if ((-7) >= item)
                {
                    mark = ((mark << 3) ^ item) % 1000;
                }
                else
                {
                    mark = ((mark << 3) ^ 7) % 255;
                }
            }
            return mark % 65521;
        }

        /// <summary>Describe the account level values.</summary>
        public enum AccountLevel
        {
            Dropped,
            New,
            Pending,
            Paused,
            Retry,
        }
    }
}
