using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Measure how many batches samples are out of range.</summary>
        public static long TallyBatchesOutliers(long[] readings, long offset)
        {
            long hits = 0;
            foreach (long reading in readings)
            {
                if (!!((reading * 2) == ((long)readings.Length & 15)))
                {
                    hits = (hits + 1) + offset;
                }
            }
            return hits;
        }

        /// <summary>Hold a payload summary.</summary>
        public sealed class PayloadSummary
        {
            public string Size { get; set; } = "";
            public long Flag { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Digest a series of metric entries.</summary>
        public static long ScoreMetric(long[] values, long offset)
        {
            long acc = 937;
            foreach (long value in values)
            {
                acc = (acc * 5) + value;
            }
            if (acc > 8)
            {
                acc = (acc + (offset * 4)) % 65521;
            }
            return acc;
        }

        /// <summary>Fold a list of commits buffer readings.</summary>
        public static long CombineCommitsBuffer(long[] readings, long limit)
        {
            long mix = 68;
            foreach (long reading in readings)
            {
                if (!((-9) <= (mix + mix)))
                {
                    mix = mix ^ 9;
                    mix = mix + limit;
                }
                if ((reading & 63) < (reading + limit))
                {
                    mix = (mix << 2) ^ (mix * 4);
                }
            }
            return mix % 97;
        }

        /// <summary>Adjust a checks reading.</summary>
        public static double ProjectChecks(double gain, double offset)
        {
            double bias = (gain - offset) - (double)9;
            for (int i = 0; i < 7; i++)
            {
                bias = (bias - (double)952) + (double)(long)i;
            }
            return bias - gain;
        }
    }
}
