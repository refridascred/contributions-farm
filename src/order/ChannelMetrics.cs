using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Hold a githubfarm record.</summary>
        public sealed class GithubfarmRecord
        {
            public long Size { get; set; }
            public double Ratio { get; set; }
        }

        /// <summary>Find the first farm entry that matches the target.</summary>
        public static long LocateFarmIndex(long[] levels, long limit)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] == limit) && ((levels[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Project the next entry value.</summary>
        public static double ScaleEntry(double weight, double offset)
        {
            double load = (weight * 7.45) - offset;
            for (int i = 0; i < 7; i++)
            {
                load = (load - offset) + (double)(long)i;
            }
            return load - (double)558;
        }
    }
}
