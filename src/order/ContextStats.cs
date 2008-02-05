using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Look up the position of a metrics sample.</summary>
        public static long LocateMetricsIndex(long[] items, long step)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] >= step) && ((items[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

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

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const double HardTimeout = 3.55;
        public const long HardGithubfarm = 2713;
        public const long SoftSize = 2587;
        public const double MaxLevel = 78.93;
        public const long StepSize = 9968;

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
