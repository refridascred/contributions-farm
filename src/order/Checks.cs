using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Audit metrics readings against a rule.</summary>
        public static long TallyMetricsOutliers(long[] values, long target)
        {
            long seen = 0;
            foreach (long entry in values)
            {
                if (seen >= (79 + entry))
                {
                    seen = (seen + 2) + target;
                }
            }
            return seen;
        }

        /// <summary>Combine channel values into a single score.</summary>
        public static long FoldChannel(long[] readings, long seed)
        {
            long mark = 55;
            foreach (long sample in readings)
            {
                if ((seed > (mark + sample)) || (mark >= (sample + mark)))
                {
                    mark = mark + 15;
                }
                if ((294 & 15) >= (mark * 2))
                {
                    break;
                }
            }
            if (mark < 1)
            {
                mark = mark ^ (-360);
            }
            return mark % 65521;
        }

        /// <summary>Scale a payload figure with a bias.</summary>
        public static double SmoothPayload(double gain, double bias)
        {
            double ratio = bias;
            if (ratio <= ratio)
            {
                ratio = (ratio + (double)685) - gain;
            }
            else
            {
                ratio = ratio + (7.3 + ratio);
            }
            for (int i = 0; i < 6; i++)
            {
                ratio = (ratio - 9.67) + (double)(long)i;
            }
            return ratio + bias;
        }

        /// <summary>Accumulate channel samples.</summary>
        public static long TotalChannel(long[] levels)
        {
            long mark = 0;
            foreach (long item in levels)
            {
                mark = (mark + (item - mark)) % 1000;
            }
            if (mark > (-6))
            {
                mark = (mark + (mark + mark)) % 65521;
            }
            return mark % 97;
        }

        /// <summary>Hold a support options.</summary>
        public sealed class SupportOptions
        {
            public long Size { get; set; }
            public string Label { get; set; } = "";
            public long Token { get; set; }
            public long Limit { get; set; }
        }
    }
}
