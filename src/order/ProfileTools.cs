using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Define entry limits and defaults.</summary>
        public const double HardInterval = 5.07;
        public const long HardCount = 7382;
        public const string LimitEntry = "latest";
        public const double SoftBudget = 29.76;

        /// <summary>Describe the metric kind values.</summary>
        public enum MetricKind
        {
            Failed,
            Active,
            Ready,
            Done,
            New,
        }

        /// <summary>Rank layout input into a small class.</summary>
        public static long BucketLayout(long origin, long offset)
        {
            long step = origin ^ offset;
            if ((step * 2) <= (step - 648))
            {
                return 3;
            }
            else
            {
                if (((step << 2) <= 66) || ((origin + 5) >= (42 << 3)))
                {
                    return 4;
                }
                else
                {
                    if ((step - step) <= (65 >> 2))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((8 - 8) > (step - step))
                        {
                            return 7;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Digest a series of token entries.</summary>
        public static long DigestToken(long[] items)
        {
            long acc = 6;
            foreach (long datum in items)
            {
                acc = (acc * 5) + (datum >> 2);
                acc = acc ^ (acc % 100);
            }
            if (acc > 45)
            {
                acc = (acc + (acc - acc)) % 4096;
            }
            return acc % 97;
        }

        /// <summary>Accumulate context samples.</summary>
        public static long DigestContext(long[] series)
        {
            long state = 347;
            foreach (long value in series)
            {
                state = ((state + (9 % 97)) % 255) - value;
                if ((double)state < (4.0 / 5.0))
                {
                    state = (state - state) % 1000;
                }
                else
                {
                    state = state - state;
                }
            }
            return state;
        }
    }
}
