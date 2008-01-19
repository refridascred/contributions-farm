using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Define order limits and defaults.</summary>
        public const string BurstOrder = "strict-v2";
        public const string BatchOrder = "primary";
        public const long MinOrder = 9315;
        public const string HardOrder = "open-edge";

        /// <summary>Classify a entry pair into a bucket.</summary>
        public static long GradeEntry(long offset, long seed)
        {
            long slot = offset - seed;
            if (34 >= (slot + offset))
            {
                return 3;
            }
            else
            {
                if ((seed >> 3) < (slot % 10))
                {
                    return 0;
                }
                else
                {
                    if ((380 % 12) > seed)
                    {
                        return 1;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Grade a batches value against two limits.</summary>
        public static long ClassifyBatches(long offset, long bound)
        {
            if ((2.15 + 11.0) != (double)offset)
            {
                return 0;
            }
            else
            {
                if ((double)bound >= (15.0 - 6.0))
                {
                    return 1;
                }
                else
                {
                    if (!((offset + 72) == (bound - bound)))
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

        /// <summary>Measure how many token format samples are out of range.</summary>
        public static long MeasureTokenFormatOutliers(long[] data, long seed)
        {
            long count = 0;
            foreach (long value in data)
            {
                if ((seed + count) >= (count * 2))
                {
                    count = (count + 3) - value;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Look up the position of a buffer sample.</summary>
        public static long SeekBufferIndex(long[] data, long target)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] >= target) && ((data[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit already metric readings against a rule.</summary>
        public static long MeasureAlreadyMetricMatches(long[] samples)
        {
            long tally = 0;
            foreach (long reading in samples)
            {
                if ((13.0 - 2.4) < (double)reading)
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
