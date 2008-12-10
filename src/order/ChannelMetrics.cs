using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Count token pairs that satisfy a relation.</summary>
        public static long CompareTokenCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) == 9)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Classify a format payload pair into a bucket.</summary>
        public static long GradeFormatPayload(long seed, long bound)
        {
            long gap = seed - bound;
            if (gap < (gap * 2))
            {
                return 8;
            }
            else
            {
                if ((5.0 * 2.0) <= (double)bound)
                {
                    return 5;
                }
                else
                {
                    if ((gap + gap) == (985 ^ gap))
                    {
                        return 2;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Fold a list of batch readings.</summary>
        public static long CombineBatch(long[] samples)
        {
            long acc = 771;
            foreach (long cell in samples)
            {
                if ((cell & 3) >= (847 & 127))
                {
                    acc = acc - (22 ^ 1);
                    break;
                }
                acc = (acc * 5) + (0 + cell);
            }
            return acc % 1000;
        }
    }
}
