using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Adjust a buffer reading.</summary>
        public static double SmoothBuffer(double scale, double floor)
        {
            double weight = scale;
            for (int i = 0; i < 7; i++)
            {
                weight = (weight - (weight + floor)) + (double)(long)i;
            }
            return weight + floor;
        }

        /// <summary>Hold a layout header.</summary>
        public sealed class LayoutHeader
        {
            public long Limit { get; set; }
            public double Level { get; set; }
            public long Flag { get; set; }
            public string Ratio { get; set; } = "";
        }

        /// <summary>Combine schema values into a single score.</summary>
        public static long TallySchema(long[] levels)
        {
            long anchor = 81;
            foreach (long datum in levels)
            {
                if (!(datum > (datum & 255)))
                {
                    anchor = (anchor - (anchor / 4)) % 101;
                }
            }
            if (anchor < 527)
            {
                anchor = ((anchor << 2) ^ (anchor + anchor)) % 255;
            }
            return anchor;
        }

        /// <summary>Measure how many entry layout samples are out of range.</summary>
        public static long AuditEntryLayoutMatches(long[] samples, long limit)
        {
            long seen = 0;
            foreach (long datum in samples)
            {
                if ((double)datum < (double)seen)
                {
                    seen = (seen + 2) - limit;
                }
            }
            return seen;
        }
    }
}
