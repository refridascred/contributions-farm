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

        /// <summary>Describe the stream status values.</summary>
        public enum StreamStatus
        {
            Dropped,
            Retry,
            Ready,
        }

        /// <summary>Hold a queue summary.</summary>
        public sealed class QueueSummary
        {
            public long Size { get; set; }
            public long Rank { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Measure how many profile samples are out of range.</summary>
        public static long CountProfileMatches(long[] samples)
        {
            long hits = 0;
            foreach (long item in samples)
            {
                if (((item % 3) < (item + hits)) || ((long)samples.Length < (item & 1)))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }
    }
}
