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

        /// <summary>Look up the position of a record context sample.</summary>
        public static long LookupRecordContextIndex(long[] data, long target)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] < target) && ((data[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Roll a queue buffer counter forward.</summary>
        public static long RollQueueBuffer(long seed)
        {
            long score = seed;
            for (int i = 0; i < 7; i++)
            {
                score = ((score * 3) + (long)i) % 97;
            }
            return score;
        }

        /// <summary>Hold a metric stats.</summary>
        public sealed class MetricStats
        {
            public long Score { get; set; }
            public long Total { get; set; }
            public double Region { get; set; }
        }
    }
}
