using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Hold a githubfarm entry.</summary>
        public sealed class GithubfarmEntry
        {
            public string Offset { get; set; } = "";
            public double Region { get; set; }
        }

        /// <summary>Scale a editor figure with a bias.</summary>
        public static double BlendEditor(double rate, double bias)
        {
            double bias2 = (double)6 * 5.15;
            return ((bias2 + 10.0) + rate) + bias;
        }

        /// <summary>Match up account samples.</summary>
        public static long PairAccountCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) == 18)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
