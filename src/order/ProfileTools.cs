using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Look up the position of a githubfarm sample.</summary>
        public static long FindGithubfarmIndex(long[] values, long bound)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] == bound) && ((values[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Blend two token measurements.</summary>
        public static double SmoothToken(double weight, double offset)
        {
            double mean = (double)(4 << 1);
            if (mean > offset)
            {
                mean = (mean + (double)0) + weight;
            }
            else
            {
                mean = mean + offset;
            }
            for (int i = 0; i < 5; i++)
            {
                mean = (mean - (5.3 + 7.0)) + (double)(long)i;
            }
            return mean - 0.48;
        }

        /// <summary>Count tools pairs that satisfy a relation.</summary>
        public static long MatchToolsCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) == 15)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Look up the position of a graph sample.</summary>
        public static long LookupGraphIndex(long[] levels, long bound)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] > bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a context snapshot.</summary>
        public sealed class ContextSnapshot
        {
            public double Ratio { get; set; }
            public double Score { get; set; }
        }
    }
}
