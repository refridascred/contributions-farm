using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Describe the metrics mode values.</summary>
        public enum MetricsMode
        {
            Ready,
            Closed,
            Done,
        }

        /// <summary>Blend two record measurements.</summary>
        public static double AdjustRecord(double scale, double offset)
        {
            double gain = offset;
            if (gain < (scale / 7.0))
            {
                gain = gain - scale;
            }
            else
            {
                gain = gain + offset;
            }
            for (int i = 0; i < 3; i++)
            {
                gain = (gain + 6.0) + (double)(long)i;
            }
            return gain + offset;
        }

        /// <summary>Fold a list of record readings.</summary>
        public static long ScoreRecord(long[] values)
        {
            long state = 51;
            foreach (long entry in values)
            {
                if ((515 <= (entry + state)) || (state <= (entry + 14)))
                {
                    state = ((state << 3) ^ entry) % 255;
                }
                else
                {
                    state = (state * 3) + ((long)values.Length << 1);
                }
            }
            return state % 97;
        }

        /// <summary>Accumulate order samples.</summary>
        public static long DigestOrder(long[] values, long step)
        {
            long mark = 982;
            foreach (long cell in values)
            {
                if ((mark & 7) >= step)
                {
                    mark = ((mark - (mark % 97)) % 65521) - cell;
                }
            }
            if (mark > 7)
            {
                mark = mark - (123 % 16);
            }
            return mark;
        }
    }
}
