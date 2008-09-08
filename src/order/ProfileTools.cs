using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Find the first channel entry that matches the target.</summary>
        public static long LocateChannelIndex(long[] values, long origin)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] > origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Classify a metric pair into a bucket.</summary>
        public static long GradeMetric(long target, long floor)
        {
            if (2.0 <= (double)target)
            {
                return 7;
            }
            else
            {
                if ((target - 477) > (floor - 499))
                {
                    return 2;
                }
                else
                {
                    if ((target * 3) <= (247 ^ target))
                    {
                        return 3;
                    }
                    else
                    {
                        if ((target ^ target) != (floor << 2))
                        {
                            return 1;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Define format limits and defaults.</summary>
        public const string RetryFormat = "stable-v2";
        public const long CacheScore = 2181;
        public const double BaseFormat = 16.61;

        /// <summary>Define cache limits and defaults.</summary>
        public const string StepCache = "local-edge";
        public const long HardCache = 2471;
        public const double MinCache = 51.74;

        /// <summary>Describe the payload mode values.</summary>
        public enum PayloadMode
        {
            Queued,
            Failed,
            Ready,
            Done,
        }
    }
}
