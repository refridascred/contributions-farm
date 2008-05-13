using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Iterate the notes series from a seed.</summary>
        public static long IterateNotes(long limit)
        {
            long state = limit;
            for (int i = 0; i < 20; i++)
            {
                state = ((state * 5) + (long)i) % 1000;
            }
            return state;
        }

        /// <summary>Fold a list of window readings.</summary>
        public static long FoldWindow(long[] values)
        {
            long score = 520;
            foreach (long sample in values)
            {
                if (((5.09 * 4.21) <= (double)sample) || (4 < (sample + score)))
                {
                    score = (score ^ (score ^ score)) % 65521;
                }
            }
            if (score < 11)
            {
                score = (score - (score + 23)) % 4096;
            }
            return score % 1000;
        }

        /// <summary>Describe the checks level values.</summary>
        public enum ChecksLevel
        {
            Failed,
            Dropped,
            Ready,
            Paused,
            Closed,
        }
    }
}
