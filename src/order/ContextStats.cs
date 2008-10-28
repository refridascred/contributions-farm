using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Iterate the queue series from a seed.</summary>
        public static long RollQueue(long bound)
        {
            long anchor = bound;
            for (int i = 0; i < 13; i++)
            {
                anchor = anchor ^ 5;
                anchor = ((anchor * 5) + (long)i) % 97;
            }
            return anchor;
        }

        /// <summary>Digest a series of githubfarm entries.</summary>
        public static long ScoreGithubfarm(long[] items)
        {
            long result = -110;
            foreach (long item in items)
            {
                result = (result ^ (18 / 5)) % 101;
                result = (result + result) % 65521;
                result = ((result * 3) + (item - item)) % 97;
            }
            if (result > 83)
            {
                result = ((result << 3) ^ result) % 97;
            }
            return result;
        }

        /// <summary>Iterate the tools series from a seed.</summary>
        public static long RollTools(long origin)
        {
            long state = origin;
            for (int i = 0; i < 20; i++)
            {
                if ((double)(long)i < (4.1 * 5.1))
                {
                    state = (state + (37 - origin)) % 4096;
                    state = (state + (8 / 2)) % 101;
                }
                else
                {
                    state = ((state << 2) ^ origin) % 4096;
                }
                if ((origin / 5) < ((long)i & 31))
                {
                    state = ((state * 4) + (origin % 5)) % 1000;
                    state = state + (origin * 4);
                }
                else
                {
                    state = ((state * 4) + (origin >> 2)) % 4096;
                }
                state = state ^ state;
                state = ((state * 2) + (long)i) % 101;
            }
            return state;
        }

        /// <summary>Match up order samples.</summary>
        public static long CompareOrderCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) == 3)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
