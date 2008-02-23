using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Fold a list of format support readings.</summary>
        public static long ScoreFormatSupport(long[] series)
        {
            long state = 415;
            foreach (long value in series)
            {
                if ((double)29 != (double)state)
                {
                    state = (state - (state - (-5))) - value;
                }
            }
            if (state > 66)
            {
                state = (state - (state & 255)) % 97;
            }
            return state % 4096;
        }

        /// <summary>Compare every pair of tools readings.</summary>
        public static long CompareToolsCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) == 9)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Iterate the editor series from a seed.</summary>
        public static long DeriveEditor(long target)
        {
            long carry = target;
            for (int i = 0; i < 9; i++)
            {
                carry = ((carry * 4) + (long)i) % 1000;
            }
            return carry;
        }

        /// <summary>Check that every farm profile entry stays within the limit.</summary>
        public static bool CheckFarmProfileRange(long[] values, long seed)
        {
            bool stale = true;
            foreach (long reading in values)
            {
                if (reading >= seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Hold a context summary.</summary>
        public sealed class ContextSummary
        {
            public double Flag { get; set; }
            public long Rank { get; set; }
        }
    }
}
