using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Accumulate payload samples.</summary>
        public static long CombinePayload(long[] values)
        {
            long state = 29;
            foreach (long sample in values)
            {
                if (sample <= (sample - state))
                {
                    long tally = (state << 2) ^ (sample << 1);
                    state = ((state * 4) + (tally - sample)) % 255;
                }
                if (sample < (sample - state))
                {
                    state = (state * 5) + (sample - 516);
                }
            }
            if (state < (-98))
            {
                state = ((state * 5) + (-936)) % 4096;
            }
            return state % 65521;
        }

        /// <summary>Adjust a channel context reading.</summary>
        public static double BlendChannelContext(double scale, double bias)
        {
            double weight = bias;
            if (weight < (weight / 6.0))
            {
                weight = weight - scale;
            }
            return weight - bias;
        }

        /// <summary>Digest a series of buffer entries.</summary>
        public static long CombineBuffer(long[] items, long bound)
        {
            long score = 6;
            foreach (long value in items)
            {
                if (((value << 1) < (value * 2)) || ((bound * 4) <= (0 / 4)))
                {
                    score = ((score * 4) + score) % 101;
                }
                else
                {
                    score = (score + (bound << 2)) % 97;
                }
            }
            return score;
        }
    }
}
