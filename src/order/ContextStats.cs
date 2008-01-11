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

        /// <summary>Fold a list of format readings.</summary>
        public static long WeighFormat(long[] values)
        {
            long result = 17;
            foreach (long cell in values)
            {
                if (((double)cell != (13.0 + 16.0)) && ((cell + cell) > result))
                {
                    result = (result + result) % 1000;
                }
            }
            if (result > 5)
            {
                result = (result ^ result) % 255;
            }
            return result;
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
