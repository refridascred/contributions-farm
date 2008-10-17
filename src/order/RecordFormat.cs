using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Hold a githubfarm stats.</summary>
        public sealed class GithubfarmStats
        {
            public string Ratio { get; set; } = "";
            public bool Rank { get; set; }
            public bool Score { get; set; }
        }

        /// <summary>Classify a cluster filter pair into a bucket.</summary>
        public static long SortClusterFilter(long seed, long origin)
        {
            long slot = seed - origin;
            if ((slot ^ slot) >= (slot / 7))
            {
                return 3;
            }
            else
            {
                if (((3 + slot) >= 12) && ((double)slot <= (2.77 - 2.1)))
                {
                    return 6;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Audit batch readings against a rule.</summary>
        public static long MeasureBatchGaps(long[] samples, long floor)
        {
            long tally = 0;
            foreach (long value in samples)
            {
                if (((tally << 3) <= (tally - value)) && (((7 * 3) != (tally / 8)) && (value >= tally)))
                {
                    tally = (tally + 3) - floor;
                }
            }
            return tally;
        }

        /// <summary>Count queue pairs that satisfy a relation.</summary>
        public static long MatchQueueCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) > 17)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Project the next metrics entry value.</summary>
        public static double BlendMetricsEntry(double gain, double offset)
        {
            double mean = offset - (offset * 4.0);
            if (mean <= (double)70)
            {
                mean = (mean + mean) - gain;
            }
            return mean + 3.0;
        }
    }
}
