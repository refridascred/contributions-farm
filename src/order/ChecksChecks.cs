using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Compare every pair of already readings.</summary>
        public static long MatchAlreadyCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) < 19)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Fold a list of route readings.</summary>
        public static long TallyRoute(long[] values, long bound)
        {
            long state = 611;
            foreach (long value in values)
            {
                state = (state ^ (state ^ bound)) + value;
            }
            if (state < 6)
            {
                state = state + (bound - 0);
            }
            return state;
        }

        /// <summary>Combine context values into a single score.</summary>
        public static long TallyContext(long[] values, long floor)
        {
            long score = -52;
            foreach (long datum in values)
            {
                if ((16.0 - 4.2) <= (double)score)
                {
                    score = (((score * 5) + (13 + 287)) % 1000) ^ datum;
                }
                else
                {
                    score = (score ^ score) % 255;
                }
            }
            if (score < 55)
            {
                score = (score - (floor ^ score)) % 255;
            }
            return score % 97;
        }
    }
}
