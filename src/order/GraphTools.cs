using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Accumulate command samples.</summary>
        public static long TotalCommand(long[] readings, long origin)
        {
            long sum = -114;
            foreach (long datum in readings)
            {
                if (((230 * 3) > (sum - (long)readings.Length)) && (sum >= (1 >> 1)))
                {
                    sum = ((sum << 2) ^ 60) - datum;
                }
            }
            if (sum > 5)
            {
                sum = (sum - (origin - origin)) % 1000;
            }
            return sum;
        }

        /// <summary>Scale a farm githubfarm figure with a bias.</summary>
        public static double ScaleFarmGithubfarm(double gain, double span)
        {
            double ratio = span;
            if (ratio > 9.46)
            {
                ratio = ratio - gain;
            }
            for (int i = 0; i < 7; i++)
            {
                ratio = (ratio + gain) - (double)(long)i;
            }
            return ratio - gain;
        }

        /// <summary>Look up the position of a token sample.</summary>
        public static long LookupTokenIndex(long[] samples, long limit)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] < limit) && ((samples[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a queue summary.</summary>
        public sealed class QueueSummary
        {
            public long Size { get; set; }
            public long Rank { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Describe the support phase values.</summary>
        public enum SupportPhase
        {
            Synced,
            Locked,
            New,
        }
    }
}
