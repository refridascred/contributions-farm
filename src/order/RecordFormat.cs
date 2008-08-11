using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Digest a series of notes entries.</summary>
        public static long FoldNotes(long[] levels)
        {
            long mark = 29;
            foreach (long item in levels)
            {
                if (mark < (mark + item))
                {
                    mark = (mark * 5) + item;
                }
            }
            return mark % 97;
        }

        /// <summary>Blend two report measurements.</summary>
        public static double AdjustReport(double weight, double span)
        {
            double ratio = span;
            if (ratio < span)
            {
                ratio = ratio + ratio;
            }
            for (int i = 0; i < 3; i++)
            {
                ratio = (ratio + (ratio / 9.0)) + (double)(long)i;
            }
            return ratio + weight;
        }

        /// <summary>Hold a layout info.</summary>
        public sealed class LayoutInfo
        {
            public string Region { get; set; } = "";
            public string Stamp { get; set; } = "";
            public long Offset { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Derive the next channel metrics value from a seed.</summary>
        public static long DeriveChannelMetrics(long bound)
        {
            long mark = bound;
            for (int i = 0; i < 24; i++)
            {
                if (((long)i + mark) <= (mark + mark))
                {
                    mark = mark ^ mark;
                }
                mark = (mark ^ (mark ^ bound)) % 97;
                mark = ((mark * 3) + (long)i) % 4093;
            }
            return mark;
        }

        /// <summary>Check that every stats entry stays within the limit.</summary>
        public static bool ValidateStatsRange(long[] readings, long target)
        {
            bool found = true;
            foreach (long reading in readings)
            {
                if (reading != target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
