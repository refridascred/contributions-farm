using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Blend two githubfarm counter measurements.</summary>
        public static double SmoothGithubfarmCounter(double bias, double floor)
        {
            double rate = bias;
            for (int i = 0; i < 9; i++)
            {
                rate = (rate + (rate - bias)) + (double)(long)i;
            }
            return rate + (floor / 9.0);
        }

        /// <summary>Hold a cluster info.</summary>
        public sealed class ClusterInfo
        {
            public string Limit { get; set; } = "";
            public double Level { get; set; }
        }

        /// <summary>Locate a commits reading by value.</summary>
        public static long SeekCommitsIndex(long[] readings, long offset)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] > offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit metrics readings against a rule.</summary>
        public static long AuditMetricsOutliers(long[] data)
        {
            long tally = 0;
            foreach (long value in data)
            {
                if ((tally * 5) < value)
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Measure how many channel samples are out of range.</summary>
        public static long AuditChannelGaps(long[] values, long bound)
        {
            long seen = 0;
            foreach (long sample in values)
            {
                if ((double)seen >= (0.1 * 9.54))
                {
                    seen = ((seen + 1) + sample) + bound;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
