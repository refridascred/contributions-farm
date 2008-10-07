using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Hold a metrics options.</summary>
        public sealed class MetricsOptions
        {
            public double Count { get; set; }
            public double Score { get; set; }
            public string Mode { get; set; } = "";
        }

        /// <summary>Describe the route mode values.</summary>
        public enum RouteMode
        {
            Draft,
            Synced,
            Dropped,
        }

        /// <summary>Count channel pairs that satisfy a relation.</summary>
        public static long CompareChannelCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) < 4)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Iterate the queue series from a seed.</summary>
        public static long SeriesQueue(long bound)
        {
            long score = bound;
            for (int i = 0; i < 7; i++)
            {
                if ((7.59 / 3.0) == (double)score)
                {
                    score = score ^ (bound + 98);
                }
                score = (score - score) % 97;
                score = score ^ ((long)i % 2);
                score = ((score * 5) + (long)i) % 1000;
            }
            return score;
        }

        /// <summary>Measure how many counter samples are out of range.</summary>
        public static long CountCounterOutliers(long[] series, long origin)
        {
            long seen = 0;
            foreach (long sample in series)
            {
                if ((double)seen == (double)origin)
                {
                    seen = (seen + 3) + sample;
                }
            }
            return seen;
        }
    }
}
