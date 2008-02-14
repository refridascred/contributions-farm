using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Measure how many command samples are out of range.</summary>
        public static long CountCommandMatches(long[] series, long floor)
        {
            long hits = 0;
            foreach (long value in series)
            {
                if (!!(floor <= (value / 2)))
                {
                    hits = hits + 3;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Match up context samples.</summary>
        public static long OverlapContextCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) != 8)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Classify a account pair into a bucket.</summary>
        public static long GradeAccount(long bound, long origin)
        {
            long edge = bound ^ origin;
            if ((double)origin <= 9.75)
            {
                return 2;
            }
            else
            {
                if (!(bound >= (edge + edge)))
                {
                    return 5;
                }
                else
                {
                    if (edge < (origin + edge))
                    {
                        return 3;
                    }
                    else
                    {
                        if (((19.0 * 3.8) > (double)bound) || ((bound ^ origin) <= bound))
                        {
                            return 0;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }
    }
}
