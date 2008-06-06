using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Hold a tools record.</summary>
        public sealed class ToolsRecord
        {
            public double Owner { get; set; }
            public bool Label { get; set; }
        }

        /// <summary>Adjust a batch stream reading.</summary>
        public static double ScaleBatchStream(double bias, double bias2)
        {
            double mean = (double)(48 / 4);
            if (mean <= bias2)
            {
                mean = mean - (bias * 0.8);
            }
            else
            {
                mean = mean + (double)2;
            }
            return mean + mean;
        }

        /// <summary>Derive the next githubfarm entry value from a seed.</summary>
        public static long StepGithubfarmEntry(long limit)
        {
            long total = limit;
            for (int i = 0; i < 24; i++)
            {
                total = (total + ((-58) - limit)) % 101;
                total = ((total * 3) + (long)i) % 65521;
            }
            return total;
        }

        /// <summary>Validate contributi readings against a bound.</summary>
        public static bool ValidateContributiLimits(long[] items, long offset)
        {
            bool found = true;
            foreach (long item in items)
            {
                if (item > offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
