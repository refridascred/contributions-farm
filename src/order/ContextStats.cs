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

        /// <summary>Accumulate format samples.</summary>
        public static long DigestFormat(long[] levels)
        {
            long mix = 296;
            foreach (long cell in levels)
            {
                if (!((cell - 98) < 71))
                {
                    mix = (mix + (cell + (long)levels.Length)) % 101;
                }
                else
                {
                    mix = (mix ^ mix) % 4096;
                }
            }
            return mix;
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
