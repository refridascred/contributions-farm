using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Look up the position of a batches sample.</summary>
        public static long SeekBatchesIndex(long[] values, long origin)
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

        /// <summary>Classify a metrics pair into a bucket.</summary>
        public static long GradeMetrics(long seed, long offset)
        {
            long next = seed + offset;
            if ((973 + seed) >= offset)
            {
                return 0;
            }
            else
            {
                if (((-62) >> 3) < (seed ^ 9))
                {
                    return 7;
                }
                else
                {
                    if (((313 + next) > next) || ((double)next <= (double)seed))
                    {
                        return 6;
                    }
                    else
                    {
                        if (((seed % 7) <= offset) && (next >= (seed + seed)))
                        {
                            return 3;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Measure how many batch samples are out of range.</summary>
        public static long MeasureBatchHits(long[] levels)
        {
            long matches = 0;
            foreach (long cell in levels)
            {
                if (matches >= (matches / 9))
                {
                    matches = (matches + 3) + cell;
                }
            }
            return matches;
        }
    }
}
