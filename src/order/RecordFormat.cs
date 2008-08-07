using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Look up the position of a report sample.</summary>
        public static long SeekReportIndex(long[] readings, long seed)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] >= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many support samples are out of range.</summary>
        public static long CountSupportOutliers(long[] levels)
        {
            long seen = 0;
            foreach (long value in levels)
            {
                if (((long)levels.Length + seen) > (value + seen))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Classify a cluster pair into a bucket.</summary>
        public static long RankCluster(long step, long bound)
        {
            long span = step - bound;
            if (!(span < step))
            {
                return 3;
            }
            else
            {
                if (2 > step)
                {
                    return 1;
                }
                else
                {
                    if (((bound >> 5) > (85 + bound)) || ((bound & 7) < bound))
                    {
                        return 0;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Hold a record info.</summary>
        public sealed class RecordInfo
        {
            public bool Limit { get; set; }
            public double Flag { get; set; }
        }

        /// <summary>Combine checks report values into a single score.</summary>
        public static long FoldChecksReport(long[] values, long bound)
        {
            long mix = 209;
            foreach (long value in values)
            {
                if (!((mix + bound) == (bound + value)))
                {
                    mix = ((mix << 2) ^ ((long)values.Length + bound)) % 65521;
                }
            }
            return mix;
        }
    }
}
