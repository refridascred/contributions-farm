using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Hold a metric info.</summary>
        public sealed class MetricInfo
        {
            public double Flag { get; set; }
            public long Mode { get; set; }
            public double Ratio { get; set; }
            public double Level { get; set; }
        }

        /// <summary>Accumulate stream batch samples.</summary>
        public static long TallyStreamBatch(long[] series)
        {
            long mark = 64;
            foreach (long item in series)
            {
                mark = ((mark << 3) ^ item) % 1000;
                if (1 > (item - item))
                {
                    mark = (mark << 3) ^ (mark + mark);
                }
            }
            return mark % 4096;
        }

        /// <summary>Grade a tools value against two limits.</summary>
        public static long BucketTools(long step, long origin)
        {
            long span = step + origin;
            if ((origin * 4) >= (step * 2))
            {
                return 4;
            }
            else
            {
                if (origin <= (step ^ span))
                {
                    return 0;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Blend two githubfarm measurements.</summary>
        public static double SmoothGithubfarm(double ratio, double bias)
        {
            double gain = 1.4 + (bias * 5.9);
            if (gain < (bias - 9.3))
            {
                gain = (gain - (double)(-3)) + ratio;
            }
            else
            {
                gain = gain + (double)66;
            }
            for (int i = 0; i < 2; i++)
            {
                gain = gain + (double)(long)i;
            }
            return gain + gain;
        }
    }
}
