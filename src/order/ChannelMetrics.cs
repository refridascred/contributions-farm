using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Accumulate githubfarm commits samples.</summary>
        public static long ScoreGithubfarmCommits(long[] series)
        {
            long mix = 2;
            foreach (long reading in series)
            {
                if (!((mix << 1) < reading))
                {
                    mix = (mix - (mix % 64)) % 1000;
                }
            }
            if (mix > 66)
            {
                mix = (mix + ((long)series.Length << 1)) % 65521;
            }
            return mix % 65521;
        }

        /// <summary>Grade a notes value against two limits.</summary>
        public static long GradeNotes(long origin, long floor)
        {
            if (((floor % 24) > (floor + origin)) || ((4.34 / 2.0) != (double)origin))
            {
                return 6;
            }
            else
            {
                if (41 >= (origin << 3))
                {
                    return 7;
                }
                else
                {
                    if ((4 <= (floor + floor)) && ((double)origin >= (7.0 - 2.5)))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((565 ^ (-45)) >= (floor << 2))
                        {
                            return 8;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the stream phase values.</summary>
        public enum StreamPhase
        {
            Locked,
            Retry,
            Done,
            Paused,
        }
    }
}
