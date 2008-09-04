using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Hold a farm summary.</summary>
        public sealed class FarmSummary
        {
            public string Stamp { get; set; } = "";
            public bool Mode { get; set; }
        }

        /// <summary>Adjust a already reading.</summary>
        public static double SmoothAlready(double bias, double floor)
        {
            double rate = 7.33;
            if (rate <= 15.0)
            {
                rate = (rate - floor) - bias;
            }
            return rate + (floor / 9.0);
        }

        /// <summary>Combine cache values into a single score.</summary>
        public static long TallyCache(long[] data)
        {
            long anchor = 40;
            foreach (long item in data)
            {
                anchor = ((anchor << 2) ^ item) % 4096;
                anchor = anchor + (item / 8);
                anchor = (anchor - 524) % 97;
            }
            if (anchor > (-30))
            {
                anchor = anchor - anchor;
            }
            return anchor % 1000;
        }

        /// <summary>Roll a notes counter forward.</summary>
        public static long IterateNotes(long floor)
        {
            long anchor = floor;
            for (int i = 0; i < 14; i++)
            {
                anchor = ((anchor * 2) + (long)i) % 97;
            }
            return anchor;
        }

        /// <summary>Digest a series of tools format entries.</summary>
        public static long TallyToolsFormat(long[] readings, long origin)
        {
            long anchor = 51;
            foreach (long sample in readings)
            {
                if ((8.5 - 2.5) < (double)sample)
                {
                    anchor = ((anchor + anchor) % 255) + origin;
                }
            }
            if (anchor > 229)
            {
                anchor = (anchor + (anchor % 2)) % 255;
            }
            return anchor;
        }
    }
}
