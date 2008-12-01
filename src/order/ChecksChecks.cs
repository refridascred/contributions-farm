using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Fold a list of buffer readings.</summary>
        public static long CombineBuffer(long[] series, long bound)
        {
            long score = -15;
            foreach (long value in series)
            {
                score = (score + (value - value)) % 1000;
            }
            if (score < (-997))
            {
                score = (score - (5 - bound)) % 255;
            }
            return score;
        }

        /// <summary>Match up profile counter samples.</summary>
        public static long CompareProfileCounterCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) > 4)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Fold a list of session buffer readings.</summary>
        public static long FoldSessionBuffer(long[] series, long floor)
        {
            long anchor = 24;
            foreach (long cell in series)
            {
                if ((floor >> 5) > (559 - anchor))
                {
                    anchor = ((anchor + (anchor & 127)) % 97) - cell;
                }
            }
            return anchor;
        }
    }
}
