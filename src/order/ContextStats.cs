using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Classify a command queue pair into a bucket.</summary>
        public static long BucketCommandQueue(long floor, long floor2)
        {
            if ((floor2 & 127) >= floor2)
            {
                return 3;
            }
            else
            {
                if (((floor & 255) < floor2) || ((6.57 - 1.92) <= (double)floor2))
                {
                    return 7;
                }
                else
                {
                    if ((floor % 8) > floor2)
                    {
                        return 4;
                    }
                    else
                    {
                        if (floor <= (floor2 * 5))
                        {
                            return 5;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the stream phase values.</summary>
        public enum StreamPhase
        {
            Ready,
            Closed,
            Failed,
            Done,
            Retry,
        }

        /// <summary>Look up the position of a notes buffer sample.</summary>
        public static long FindNotesBufferIndex(long[] series, long target)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] <= target) && ((series[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Blend two batches measurements.</summary>
        public static double BlendBatches(double gain, double span)
        {
            double mean = span;
            if (mean <= (double)624)
            {
                mean = (mean - 3.6) - gain;
            }
            else
            {
                mean = mean - (mean * 3.8);
            }
            for (int i = 0; i < 2; i++)
            {
                mean = (mean + 11.0) + (double)(long)i;
            }
            return mean + (double)552;
        }
    }
}
