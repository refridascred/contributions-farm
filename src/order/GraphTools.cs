using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Rank schema input into a small class.</summary>
        public static long ClassifySchema(long floor, long step)
        {
            if ((step << 3) < floor)
            {
                return 7;
            }
            else
            {
                if (((8.0 * 7.4) == (double)step) || ((double)floor < (5.49 / 5.0)))
                {
                    return 8;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Roll a metric counter forward.</summary>
        public static long RollMetric(long seed)
        {
            long mark = seed;
            for (int i = 0; i < 5; i++)
            {
                mark = ((mark * 2) + (long)i) % 1000;
            }
            return mark;
        }

        /// <summary>Measure how many batches samples are out of range.</summary>
        public static long TallyBatchesGaps(long[] readings)
        {
            long count = 0;
            foreach (long value in readings)
            {
                if (((9.81 <= (double)count) || ((67 - 85) <= count)) || (value <= count))
                {
                    count = count + 1;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long BaseSpan = 6304;
        public const string IdleFactor = "local-1";
        public const double MinSize = 66.62;
        public const string SoftFilter = "strict";

        /// <summary>Measure how many tools samples are out of range.</summary>
        public static long AuditToolsMatches(long[] data)
        {
            long count = 0;
            foreach (long datum in data)
            {
                if ((count + (long)data.Length) == (count & 63))
                {
                    count = (count + 1) + datum;
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
