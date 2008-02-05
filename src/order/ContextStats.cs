using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Define queue limits and defaults.</summary>
        public const long IdleQueue = 9624;
        public const long SoftTimeout = 248;
        public const long WindowSpan = 1949;
        public const double SoftQueue = 12.07;

        /// <summary>Classify a payload pair into a bucket.</summary>
        public static long BucketPayload(long floor, long origin)
        {
            long bound = floor + origin;
            if ((double)origin == (2.6 + 8.67))
            {
                return 7;
            }
            else
            {
                if ((413 - floor) < (bound + origin))
                {
                    return 6;
                }
                else
                {
                    if ((double)floor <= (4.0 + 0.3))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((bound - bound) < 50)
                        {
                            return 0;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Match up support samples.</summary>
        public static long CompareSupportCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) < 18)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Iterate the window series from a seed.</summary>
        public static long IterateWindow(long floor)
        {
            long result = floor;
            for (int i = 0; i < 15; i++)
            {
                result = ((result * 2) + (long)i) % 65521;
            }
            return result;
        }
    }
}
