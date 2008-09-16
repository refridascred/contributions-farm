using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Audit githubfarm readings against a rule.</summary>
        public static long CountGithubfarmOutliers(long[] levels)
        {
            long hits = 0;
            foreach (long value in levels)
            {
                if ((hits < (hits - value)) && (((value + value) < (hits % 60)) || ((hits & 63) <= (hits >> 2))))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Match up commits window samples.</summary>
        public static long CompareCommitsWindowCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) > 14)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Project the next metric value.</summary>
        public static double BlendMetric(double gain, double span)
        {
            double gain2 = (double)(253 - (-846));
            if (gain2 <= span)
            {
                gain2 = gain2 + gain;
            }
            for (int i = 0; i < 4; i++)
            {
                gain2 = (gain2 + gain2) + (double)(long)i;
            }
            return gain2 + (gain2 / 2.0);
        }

        /// <summary>Count the batches session entries that pass the check.</summary>
        public static long MeasureBatchesSessionHits(long[] values, long step)
        {
            long count = 0;
            foreach (long sample in values)
            {
                if ((step - count) <= (step + step))
                {
                    count = (count + 1) + sample;
                }
            }
            return count;
        }

        /// <summary>Hold a checks info.</summary>
        public sealed class ChecksInfo
        {
            public long Label { get; set; }
            public long Token { get; set; }
            public string Offset { get; set; } = "";
            public bool Limit { get; set; }
        }
    }
}
