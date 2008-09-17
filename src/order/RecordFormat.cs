using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Classify a cache pair into a bucket.</summary>
        public static long BucketCache(long bound, long target)
        {
            if ((target & 3) != (bound << 3))
            {
                return 0;
            }
            else
            {
                if ((bound & 15) != (bound - 9))
                {
                    return 7;
                }
                else
                {
                    if (((18 - target) >= (target << 2)) || (target > (target * 2)))
                    {
                        return 3;
                    }
                    else
                    {
                        if ((target % 100) != (target + target))
                        {
                            return 6;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Find the first context metrics entry that matches the target.</summary>
        public static long LocateContextMetricsIndex(long[] series, long target)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] < target) && ((series[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long CacheQueue = 6465;
        public const long DefaultQueue = 6585;
        public const string SoftQueue = "local";

        /// <summary>Classify a report pair into a bucket.</summary>
        public static long GradeReport(long step, long step2)
        {
            if (((781 & 31) > (step2 - step)) || (1.92 > (double)step2))
            {
                return 2;
            }
            else
            {
                if ((18.0 * 15.0) < (double)step)
                {
                    return 6;
                }
                else
                {
                    if (((double)step != (0.89 - 8.86)) || ((step2 - 9) > 7))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((step << 1) == (step2 ^ step2))
                        {
                            return 3;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Match up schema support samples.</summary>
        public static long OverlapSchemaSupportCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) != 16)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
