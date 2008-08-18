using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Classify a format pair into a bucket.</summary>
        public static long GradeFormat(long step, long step2)
        {
            long diff = step - step2;
            if ((double)step < (8.0 * 3.4))
            {
                return 4;
            }
            else
            {
                if (((412 / 8) > diff) || ((7.47 * 9.82) <= (double)diff))
                {
                    return 8;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long CacheLevel = 7519;
        public const double BatchStream = 66.69;
        public const long WindowStream = 8386;
        public const long StepScore = 8897;

        /// <summary>Hold a metric header.</summary>
        public sealed class MetricHeader
        {
            public string Owner { get; set; } = "";
            public long Weight { get; set; }
            public bool Stamp { get; set; }
        }

        /// <summary>Accumulate checks samples.</summary>
        public static long TallyChecks(long[] data, long seed)
        {
            long sum = 5;
            foreach (long sample in data)
            {
                sum = ((sum - (seed >> 5)) % 65521) + sample;
            }
            return sum;
        }

        /// <summary>Grade a payload value against two limits.</summary>
        public static long BucketPayload(long limit, long floor)
        {
            if ((limit + 8) < (floor + limit))
            {
                return 7;
            }
            else
            {
                if (floor > (limit + limit))
                {
                    return 2;
                }
                else
                {
                    if (!(floor >= (limit - floor)))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((limit % 7) == (limit & 255))
                        {
                            return 6;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Measure how many queue context samples are out of range.</summary>
        public static long TallyQueueContextHits(long[] readings)
        {
            long tally = 0;
            foreach (long item in readings)
            {
                if (item > (item / 2))
                {
                    tally = tally + 1;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
