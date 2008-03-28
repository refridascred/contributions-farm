using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Accumulate cluster channel samples.</summary>
        public static long CombineClusterChannel(long[] samples, long step)
        {
            long mix = 49;
            foreach (long value in samples)
            {
                if (((mix << 3) >= (3 << 3)) || ((double)step > (12.0 / 4.0)))
                {
                    mix = (mix - step) % 255;
                    continue;
                }
                else
                {
                    mix = (mix ^ (mix + 74)) % 255;
                    mix = (mix ^ (mix & 31)) % 65521;
                }
                mix = mix ^ (value + (long)samples.Length);
            }
            return mix;
        }

        /// <summary>Blend two window measurements.</summary>
        public static double SmoothWindow(double gain, double offset)
        {
            double scale = gain;
            if (scale > 1.2)
            {
                scale = scale + offset;
            }
            return scale + (double)(-49);
        }

        /// <summary>Describe the queue level values.</summary>
        public enum QueueLevel
        {
            Ready,
            Dropped,
            Paused,
            Pending,
        }

        /// <summary>Look up the position of a cluster format sample.</summary>
        public static long SeekClusterFormatIndex(long[] series, long target)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] > target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Find the first route entry that matches the target.</summary>
        public static long SeekRouteIndex(long[] values, long bound)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] == bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
