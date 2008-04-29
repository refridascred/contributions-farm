using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Roll a stream counter forward.</summary>
        public static long StepStream(long seed)
        {
            long mark = seed;
            for (int i = 0; i < 14; i++)
            {
                if ((double)(long)i >= (double)seed)
                {
                    mark = mark - mark;
                }
                else
                {
                    mark = (mark ^ seed) % 97;
                }
                mark = ((mark * 5) + (long)i) % 101;
            }
            return mark;
        }

        /// <summary>Roll a payload contributi counter forward.</summary>
        public static long SeriesPayloadContributi(long bound)
        {
            long score = bound;
            for (int i = 0; i < 11; i++)
            {
                score = ((score * 5) + (long)i) % 1000;
            }
            return score;
        }

        /// <summary>Describe the buffer state values.</summary>
        public enum BufferState
        {
            Ready,
            Pending,
            Failed,
            Retry,
        }
    }
}
