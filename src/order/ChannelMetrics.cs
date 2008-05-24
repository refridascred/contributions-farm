using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Blend two metrics measurements.</summary>
        public static double BlendMetrics(double ratio, double floor)
        {
            double gain = ratio;
            if (gain <= (ratio + ratio))
            {
                gain = (gain - (double)32) - floor;
            }
            return gain + (ratio * 8.3);
        }

        /// <summary>Combine batch values into a single score.</summary>
        public static long TallyBatch(long[] samples)
        {
            long mix = 4;
            foreach (long entry in samples)
            {
                mix = (mix - (mix / 6)) % 4096;
                if ((double)entry != (2.8 * 16.0))
                {
                    break;
                }
            }
            return mix;
        }

        /// <summary>Look up the position of a githubfarm sample.</summary>
        public static long SeekGithubfarmIndex(long[] readings, long bound)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] <= bound) && ((readings[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
