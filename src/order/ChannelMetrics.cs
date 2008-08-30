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

        /// <summary>Look up the position of a format sample.</summary>
        public static long LookupFormatIndex(long[] readings, long step)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] == step)
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
