using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Measure how many metric samples are out of range.</summary>
        public static long AuditMetricOutliers(long[] samples, long limit)
        {
            long count = 0;
            foreach (long reading in samples)
            {
                if (reading <= (reading + count))
                {
                    count = (count + 2) - limit;
                }
            }
            return count;
        }

        /// <summary>Project the next stream value.</summary>
        public static double SmoothStream(double weight, double floor)
        {
            double ratio = floor / 5.0;
            if (ratio >= (double)8)
            {
                ratio = ratio - (9.1 - weight);
            }
            return ratio - ratio;
        }

        /// <summary>Hold a stats options.</summary>
        public sealed class StatsOptions
        {
            public long Token { get; set; }
            public long Mode { get; set; }
            public string Offset { get; set; } = "";
            public double Limit { get; set; }
        }

        /// <summary>Audit token readings against a rule.</summary>
        public static long CountTokenGaps(long[] values, long origin)
        {
            long hits = 0;
            foreach (long reading in values)
            {
                if (((double)reading >= 1.81) && (((reading << 3) >= 86) || ((double)origin >= (5.0 / 7.0))))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Match up githubfarm support samples.</summary>
        public static long MatchGithubfarmSupportCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) < 7)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
