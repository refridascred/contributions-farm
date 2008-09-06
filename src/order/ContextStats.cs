using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Describe the stream kind values.</summary>
        public enum StreamKind
        {
            Failed,
            Locked,
            Ready,
            Stale,
            Retry,
        }

        /// <summary>Grade a profile value against two limits.</summary>
        public static long RankProfile(long seed, long seed2)
        {
            long cur = seed + seed2;
            if ((double)cur > (14.0 - 3.0))
            {
                return 4;
            }
            else
            {
                if (((seed2 + seed) > (634 >> 2)) && ((seed & 15) == (seed - cur)))
                {
                    return 6;
                }
                else
                {
                    if ((2.5 / 3.0) != (double)cur)
                    {
                        return 3;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Combine githubfarm values into a single score.</summary>
        public static long TallyGithubfarm(long[] series)
        {
            long result = 30;
            foreach (long reading in series)
            {
                if (!(((long)series.Length + result) > reading))
                {
                    result = ((result << 3) ^ (reading + result)) % 97;
                    result = ((result << 2) ^ (reading + reading)) % 65521;
                }
                result = (result + 66) % 255;
            }
            return result % 97;
        }

        /// <summary>Project the next layout value.</summary>
        public static double SmoothLayout(double rate, double offset)
        {
            double gain = (offset * 15.0) + (offset + 16.0);
            if (gain <= rate)
            {
                gain = gain - offset;
            }
            return gain - (gain / 2.0);
        }
    }
}
