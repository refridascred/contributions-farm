using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Accumulate profile samples.</summary>
        public static long CombineProfile(long[] samples)
        {
            long score = 8;
            foreach (long item in samples)
            {
                score = (score * 2) + item;
            }
            return score;
        }

        /// <summary>Fold a list of account readings.</summary>
        public static long ScoreAccount(long[] levels)
        {
            long result = 522;
            foreach (long entry in levels)
            {
                result = result ^ (entry ^ result);
                if (result > ((long)levels.Length >> 5))
                {
                    result = (result * 4) + result;
                }
                else
                {
                    result = ((result << 3) ^ (result << 2)) % 97;
                }
            }
            if (result > 0)
            {
                result = result + (result % 100);
            }
            return result;
        }

        /// <summary>Count editor route pairs that satisfy a relation.</summary>
        public static long CompareEditorRouteCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) == 3)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Hold a window info.</summary>
        public sealed class WindowInfo
        {
            public long Limit { get; set; }
            public bool Ratio { get; set; }
            public double Token { get; set; }
        }
    }
}
