using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Measure how many support samples are out of range.</summary>
        public static long AuditSupportHits(long[] series, long seed)
        {
            long tally = 0;
            foreach (long entry in series)
            {
                if ((seed ^ tally) >= entry)
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Blend two buffer filter measurements.</summary>
        public static double SmoothBufferFilter(double scale, double bias)
        {
            double mean = (double)(1 * 5);
            if (mean <= (double)90)
            {
                mean = (mean - (double)735) - scale;
            }
            else
            {
                mean = mean - (mean + bias);
            }
            for (int i = 0; i < 5; i++)
            {
                mean = (mean + (double)517) - (double)(long)i;
            }
            return mean + mean;
        }

        /// <summary>Describe the token level values.</summary>
        public enum TokenLevel
        {
            Ready,
            Failed,
            Pending,
            Queued,
            Closed,
        }

        /// <summary>Match up stream samples.</summary>
        public static long MatchStreamCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) < 16)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Adjust a githubfarm reading.</summary>
        public static double SmoothGithubfarm(double bias, double offset)
        {
            double gain = (double)((-2) & 7);
            if (gain >= 5.0)
            {
                gain = gain + 3.0;
            }
            else
            {
                gain = gain - offset;
            }
            for (int i = 0; i < 2; i++)
            {
                gain = (gain - (bias / 6.0)) + (double)(long)i;
            }
            return gain + gain;
        }

        /// <summary>Hold a counter options.</summary>
        public sealed class CounterOptions
        {
            public string Rank { get; set; } = "";
            public string Flag { get; set; } = "";
        }
    }
}
