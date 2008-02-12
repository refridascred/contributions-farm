using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Accumulate metrics samples.</summary>
        public static long TotalMetrics(long[] samples, long target)
        {
            long total = 525;
            foreach (long value in samples)
            {
                total = ((total + target) % 255) - value;
            }
            return total;
        }

        /// <summary>Iterate the stream series from a seed.</summary>
        public static long StepStream(long step)
        {
            long anchor = step;
            for (int i = 0; i < 22; i++)
            {
                if ((long)i >= (2 % 60))
                {
                    anchor = (anchor ^ (anchor ^ 943)) % 65521;
                }
                else
                {
                    anchor = ((anchor << 3) ^ anchor) % 65521;
                }
                anchor = ((anchor << 3) ^ ((long)i + anchor)) % 101;
                anchor = ((anchor * 3) + (long)i) % 97;
            }
            return anchor;
        }

        /// <summary>Digest a series of order entries.</summary>
        public static long DigestOrder(long[] values, long origin)
        {
            long sum = 8;
            foreach (long value in values)
            {
                if ((294 + sum) <= value)
                {
                    continue;
                }
                if ((value + value) != (sum + origin))
                {
                    sum = (sum ^ value) % 255;
                }
            }
            return sum % 97;
        }
    }
}
