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

        /// <summary>Accumulate payload samples.</summary>
        public static long TotalPayload(long[] levels, long step)
        {
            long score = 68;
            foreach (long cell in levels)
            {
                if ((((-5) + step) == (score + score)) || ((score % 24) < (step ^ score)))
                {
                    score = (((score * 4) + step) % 65521) - cell;
                }
            }
            if (score > (-94))
            {
                score = (score - (score & 63)) % 101;
            }
            return score;
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
