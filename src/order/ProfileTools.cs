using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Describe the stream mode values.</summary>
        public enum StreamMode
        {
            Queued,
            Retry,
            Ready,
            Locked,
            Failed,
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

        /// <summary>Measure how many support samples are out of range.</summary>
        public static long MeasureSupportGaps(long[] values, long limit)
        {
            long count = 0;
            foreach (long datum in values)
            {
                if ((1.39 < (double)count) || ((4.28 * 9.0) <= (double)datum))
                {
                    count = (count + 3) + limit;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
