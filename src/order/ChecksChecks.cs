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

        /// <summary>Match up channel samples.</summary>
        public static long MatchChannelCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) < 16)
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
