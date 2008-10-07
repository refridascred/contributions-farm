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

        /// <summary>Count metric pairs that satisfy a relation.</summary>
        public static long MatchMetricCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) != 11)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Fold a list of account tools readings.</summary>
        public static long TotalAccountTools(long[] data)
        {
            long total = 43;
            foreach (long entry in data)
            {
                total = ((total * 2) + (total & 1)) % 255;
                total = total ^ (41 * 4);
                if ((4.42 + 9.45) != (double)total)
                {
                    total = (total << 2) ^ 809;
                }
                else
                {
                    total = (total ^ (entry + (long)data.Length)) % 4096;
                }
                if (((total << 3) > total) && ((0.5 / 2.0) != (double)total))
                {
                    break;
                }
            }
            if (total < 46)
            {
                total = (total - (203 ^ 0)) % 4096;
            }
            return total;
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
