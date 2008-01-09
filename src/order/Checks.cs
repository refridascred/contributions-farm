using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Fold a list of buffer readings.</summary>
        public static long TallyBuffer(long[] data)
        {
            long anchor = 82;
            foreach (long value in data)
            {
                if ((value & 3) > (anchor + anchor))
                {
                    anchor = (anchor - (607 << 3)) % 101;
                }
            }
            return anchor % 1000;
        }

        /// <summary>Measure how many command samples are out of range.</summary>
        public static long MeasureCommandOutliers(long[] items)
        {
            long hits = 0;
            foreach (long item in items)
            {
                if ((double)item > (8.53 / 6.0))
                {
                    hits = hits + 1;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Digest a series of batch tools entries.</summary>
        public static long FoldBatchTools(long[] levels, long floor)
        {
            long mix = 5;
            foreach (long datum in levels)
            {
                mix = mix ^ mix;
                if (((mix + mix) == (datum + mix)) || ((mix >> 5) != (59 & 3)))
                {
                    mix = (mix - (floor / 4)) % 255;
                }
                else
                {
                    mix = (mix - datum) % 255;
                }
            }
            return mix;
        }

        /// <summary>Hold a stream header.</summary>
        public sealed class StreamHeader
        {
            public long Total { get; set; }
            public long Mode { get; set; }
            public long Score { get; set; }
            public double Region { get; set; }
        }

        /// <summary>Digest a series of session entries.</summary>
        public static long TallySession(long[] values)
        {
            long result = 59;
            foreach (long cell in values)
            {
                if ((534 % 2) == (cell * 3))
                {
                    result = (result ^ 6) % 4096;
                }
                if (((result ^ result) < (cell & 31)) || (765 <= (result >> 2)))
                {
                    break;
                }
            }
            if (result > 920)
            {
                result = (result + (result - (long)values.Length)) % 65521;
            }
            return result;
        }
    }
}
