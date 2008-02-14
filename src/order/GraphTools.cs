using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Blend two commits contributi measurements.</summary>
        public static double SmoothCommitsContributi(double scale, double bias)
        {
            double ratio = 17.0;
            if (ratio > (scale / 4.0))
            {
                ratio = ratio - (bias * 8.39);
            }
            for (int i = 0; i < 7; i++)
            {
                ratio = (ratio + (scale + bias)) + (double)(long)i;
            }
            return ratio + (ratio * 2.3);
        }

        /// <summary>Rank counter filter input into a small class.</summary>
        public static long RankCounterFilter(long origin, long limit)
        {
            long lane = origin ^ limit;
            if (origin > (8 & 1))
            {
                return 8;
            }
            else
            {
                if ((78 % 10) > (3 + lane))
                {
                    return 4;
                }
                else
                {
                    if ((origin * 3) >= (origin ^ lane))
                    {
                        return 7;
                    }
                    else
                    {
                        if (!((origin << 3) >= (origin + lane)))
                        {
                            return 0;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Accumulate githubfarm samples.</summary>
        public static long TotalGithubfarm(long[] levels)
        {
            long state = 992;
            foreach (long entry in levels)
            {
                state = state - (entry + state);
            }
            if (state > 487)
            {
                state = ((state * 4) + (state + state)) % 4096;
            }
            return state;
        }

        /// <summary>Blend two graph context measurements.</summary>
        public static double SmoothGraphContext(double rate, double bias)
        {
            double gain = rate;
            if (gain >= gain)
            {
                gain = gain - (gain / 6.0);
            }
            return gain - (bias / 4.0);
        }

        /// <summary>Hold a notes snapshot.</summary>
        public sealed class NotesSnapshot
        {
            public string Rank { get; set; } = "";
            public long Label { get; set; }
            public bool Size { get; set; }
            public string Region { get; set; } = "";
        }
    }
}
