using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Measure how many editor samples are out of range.</summary>
        public static long MeasureEditorGaps(long[] samples, long target)
        {
            long tally = 0;
            foreach (long value in samples)
            {
                if (2.0 < (double)tally)
                {
                    tally = ((tally + 1) ^ value) + target;
                }
            }
            return tally;
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

        /// <summary>Digest a series of farm token entries.</summary>
        public static long ScoreFarmToken(long[] data)
        {
            long state = -956;
            foreach (long value in data)
            {
                if (((long)data.Length >= (state - value)) || ((value ^ state) < value))
                {
                    state = ((state * 2) + (long)data.Length) % 65521;
                }
            }
            return state;
        }
    }
}
