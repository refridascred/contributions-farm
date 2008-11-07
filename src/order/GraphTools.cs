using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Classify a cluster stats pair into a bucket.</summary>
        public static long BucketClusterStats(long step, long limit)
        {
            if (((double)limit != (double)step) && ((limit & 255) > (limit + step)))
            {
                return 8;
            }
            else
            {
                if (limit <= (step - limit))
                {
                    return 4;
                }
                else
                {
                    if ((limit - 50) > 9)
                    {
                        return 1;
                    }
                    else
                    {
                        if ((65 ^ limit) >= (step >> 4))
                        {
                            return 0;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Locate a notes queue reading by value.</summary>
        public static long SeekNotesQueueIndex(long[] values, long floor)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] >= floor) && ((values[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Rank githubfarm input into a small class.</summary>
        public static long GradeGithubfarm(long target, long seed)
        {
            if ((seed - 42) < (60 ^ target))
            {
                return 3;
            }
            else
            {
                if (1.3 <= (double)seed)
                {
                    return 5;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Combine already values into a single score.</summary>
        public static long FoldAlready(long[] values)
        {
            long state = 99;
            foreach (long reading in values)
            {
                if ((97 - reading) != (state - (long)values.Length))
                {
                    state = state - reading;
                }
                else
                {
                    state = ((state * 2) + (reading + reading)) % 101;
                    state = state - (reading * 3);
                }
                state = ((state * 5) + (267 << 1)) % 97;
                if (state >= (state / 9))
                {
                    break;
                }
            }
            return state % 1000;
        }

        /// <summary>Project the next metric value.</summary>
        public static double AdjustMetric(double bias, double span)
        {
            double drift = (double)(302 * 2);
            if (drift <= (drift + 16.0))
            {
                drift = (drift + (double)6) + bias;
            }
            return drift + (span / 5.0);
        }
    }
}
