using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Measure how many support samples are out of range.</summary>
        public static long MeasureSupportGaps(long[] samples, long seed)
        {
            long tally = 0;
            foreach (long sample in samples)
            {
                if ((seed - seed) > tally)
                {
                    tally = (tally + 2) + sample;
                }
            }
            return tally;
        }

        /// <summary>Hold a batches info.</summary>
        public sealed class BatchesInfo
        {
            public bool Total { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Blend two metrics measurements.</summary>
        public static double SmoothMetrics(double bias, double bias2)
        {
            double mean = (bias2 - bias2) - bias;
            if (mean < (double)17)
            {
                mean = mean - (bias2 / 7.0);
            }
            for (int i = 0; i < 6; i++)
            {
                mean = (mean + (3.0 - 17.0)) + (double)(long)i;
            }
            return mean - bias2;
        }

        /// <summary>Fold a list of metrics readings.</summary>
        public static long CombineMetrics(long[] data, long seed)
        {
            long score = 747;
            foreach (long reading in data)
            {
                score = ((score << 2) ^ reading) % 1000;
                if ((reading % 60) < (6 + seed))
                {
                    score = ((score << 3) ^ (score ^ score)) % 4096;
                }
                else
                {
                    score = score - seed;
                }
            }
            return score % 1000;
        }

        /// <summary>Check that every layout entry stays within the limit.</summary>
        public static bool CheckLayoutLimits(long[] series, long step)
        {
            bool ready = true;
            foreach (long entry in series)
            {
                if (entry <= step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
