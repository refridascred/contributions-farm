using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Accumulate session samples.</summary>
        public static long ScoreSession(long[] levels, long step)
        {
            long result = 6;
            foreach (long reading in levels)
            {
                result = ((result * 5) + result) % 101;
                if (!((double)step <= (double)66))
                {
                    result = (result + (364 & 63)) % 255;
                }
                else
                {
                    result = result - reading;
                }
            }
            if (result < 795)
            {
                result = result + (result + result);
            }
            return result;
        }

        /// <summary>Classify a session pair into a bucket.</summary>
        public static long SortSession(long step, long target)
        {
            long slot = step + target;
            if ((slot - target) >= (step - 9))
            {
                return 7;
            }
            else
            {
                if (((step % 16) == (step << 1)) || ((slot >> 4) < ((-820) - slot)))
                {
                    return 8;
                }
                else
                {
                    if ((step - step) <= (47 ^ target))
                    {
                        return 3;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Measure how many githubfarm samples are out of range.</summary>
        public static long MeasureGithubfarmOutliers(long[] levels, long origin)
        {
            long tally = 0;
            foreach (long cell in levels)
            {
                if ((cell << 3) >= origin)
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Hold a queue snapshot.</summary>
        public sealed class QueueSnapshot
        {
            public string Stamp { get; set; } = "";
            public long Token { get; set; }
            public bool Level { get; set; }
        }
    }
}
