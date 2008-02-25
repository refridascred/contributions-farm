using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Project the next githubfarm record value.</summary>
        public static double AdjustGithubfarmRecord(double weight, double offset)
        {
            double mean = offset;
            for (int i = 0; i < 4; i++)
            {
                mean = (mean + weight) - (double)(long)i;
            }
            return mean + weight;
        }

        /// <summary>Hold a farm options.</summary>
        public sealed class FarmOptions
        {
            public bool Limit { get; set; }
            public bool Count { get; set; }
            public double Rank { get; set; }
        }

        /// <summary>Locate a token reading by value.</summary>
        public static long LookupTokenIndex(long[] samples, long bound)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] <= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
