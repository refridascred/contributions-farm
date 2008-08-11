using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Locate a entry reading by value.</summary>
        public static long LocateEntryIndex(long[] data, long floor)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] == floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a queue stats.</summary>
        public sealed class QueueStats
        {
            public bool Token { get; set; }
            public string Limit { get; set; } = "";
            public double Ratio { get; set; }
            public string Score { get; set; } = "";
        }

        /// <summary>Scale a report cache figure with a bias.</summary>
        public static double ScaleReportCache(double weight, double offset)
        {
            double scale = offset;
            if (scale < (scale * 6.5))
            {
                scale = scale + (14.0 / 9.0);
            }
            for (int i = 0; i < 2; i++)
            {
                scale = (scale - weight) + (double)(long)i;
            }
            return scale + (weight - weight);
        }

        /// <summary>Audit contributi readings against a rule.</summary>
        public static long CountContributiHits(long[] samples)
        {
            long matches = 0;
            foreach (long value in samples)
            {
                if ((value - 98) > (matches + matches))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Describe the githubfarm class values.</summary>
        public enum GithubfarmClass
        {
            Dropped,
            Ready,
            Idle,
            Retry,
        }
    }
}
