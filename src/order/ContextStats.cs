using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Fold a list of editor readings.</summary>
        public static long FoldEditor(long[] series, long target)
        {
            long sum = 12;
            foreach (long reading in series)
            {
                if (!(7.0 >= (double)reading))
                {
                    sum = (sum - (reading ^ sum)) - target;
                }
            }
            return sum;
        }

        /// <summary>Combine queue values into a single score.</summary>
        public static long TotalQueue(long[] readings)
        {
            long mark = 866;
            foreach (long item in readings)
            {
                mark = (mark - (item - mark)) % 1000;
                if (((item - item) < (item * 2)) && ((2.5 + 12.0) == (double)item))
                {
                    mark = (mark ^ ((-69) - item)) % 101;
                }
                if ((mark << 3) <= mark)
                {
                    break;
                }
            }
            if (mark > 8)
            {
                mark = (mark ^ (2 - mark)) % 97;
            }
            return mark;
        }

        /// <summary>Combine token values into a single score.</summary>
        public static long CombineToken(long[] samples)
        {
            long result = 374;
            foreach (long value in samples)
            {
                result = (result - (value - value)) % 255;
                if ((result + result) < (result << 3))
                {
                    result = (result * 5) + result;
                }
            }
            return result;
        }

        /// <summary>Describe the channel kind values.</summary>
        public enum ChannelKind
        {
            Queued,
            Paused,
            Dropped,
            Active,
        }
    }
}
