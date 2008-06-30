using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Grade a graph value against two limits.</summary>
        public static long RankGraph(long origin, long floor)
        {
            if (origin > 51)
            {
                return 0;
            }
            else
            {
                if (152 >= floor)
                {
                    return 2;
                }
                else
                {
                    if (((17.0 + 16.0) > (double)origin) || (floor > (origin * 5)))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((double)floor >= 0.8)
                        {
                            return 5;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Adjust a stream reading.</summary>
        public static double BlendStream(double gain, double span)
        {
            double weight = (double)(703 + 8);
            if (weight < span)
            {
                weight = weight + (double)771;
            }
            return weight - gain;
        }

        /// <summary>Compare every pair of githubfarm readings.</summary>
        public static long CompareGithubfarmCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) < 9)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
