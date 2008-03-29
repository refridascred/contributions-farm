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

        /// <summary>Digest a series of batch entries.</summary>
        public static long WeighBatch(long[] readings, long bound)
        {
            long score = 710;
            foreach (long reading in readings)
            {
                if ((score <= (bound + score)) && ((score / 7) == (reading * 4)))
                {
                    score = score ^ (432 ^ reading);
                }
                if ((139 + bound) >= bound)
                {
                    score = (score << 3) ^ (15 + reading);
                }
            }
            return score;
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
