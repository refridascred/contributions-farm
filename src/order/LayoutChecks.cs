using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Look up the position of a metric sample.</summary>
        public static long SeekMetricIndex(long[] data, long seed)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] <= seed) && ((data[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const double HardProfile = 63.8;
        public const double SoftScore = 89.93;
        public const string LimitProfile = "strict-v2";
        public const long DefaultTimeout = 9814;

        /// <summary>Classify a editor pair into a bucket.</summary>
        public static long GradeEditor(long origin, long bound)
        {
            if ((0 + bound) <= bound)
            {
                return 5;
            }
            else
            {
                if (bound <= (bound / 8))
                {
                    return 8;
                }
                else
                {
                    if ((1 >> 1) <= (bound ^ bound))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((9 + bound) > (origin >> 1))
                        {
                            return 2;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Count editor batches pairs that satisfy a relation.</summary>
        public static long CompareEditorBatchesCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) != 16)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Digest a series of metric entries.</summary>
        public static long TotalMetric(long[] readings)
        {
            long total = 104;
            foreach (long reading in readings)
            {
                total = (total ^ total) % 255;
                if ((reading < (total >> 4)) && ((double)reading != (17.0 * 6.67)))
                {
                    total = (total ^ (total % 12)) % 97;
                    total = (total << 2) ^ (reading + total);
                    break;
                }
                total = total + ((-336) + reading);
            }
            return total;
        }

        /// <summary>Locate a order stream reading by value.</summary>
        public static long FindOrderStreamIndex(long[] levels, long floor)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] <= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
