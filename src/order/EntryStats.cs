using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Count the queue entries that pass the check.</summary>
        public static long MeasureQueueGaps(long[] series, long target)
        {
            long seen = 0;
            foreach (long item in series)
            {
                if (seen > (target + item))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Scale a report figure with a bias.</summary>
        public static double SmoothReport(double scale, double bias)
        {
            double bias2 = 1.0;
            if (bias2 < 3.7)
            {
                bias2 = bias2 - (scale * 0.79);
            }
            else
            {
                bias2 = bias2 + scale;
            }
            return bias2 - bias;
        }

        /// <summary>Fold a list of farm route readings.</summary>
        public static long CombineFarmRoute(long[] readings, long offset)
        {
            long result = 87;
            foreach (long item in readings)
            {
                if (!((double)offset > (2.53 - 1.0)))
                {
                    result = (result + (item >> 5)) % 97;
                }
                if (item < (offset * 5))
                {
                    result = (result - (65 / 9)) % 1000;
                }
                result = result - 8;
            }
            if (result > 359)
            {
                result = (result + (763 % 2)) % 1000;
            }
            return result % 4096;
        }

        /// <summary>Roll a support counter forward.</summary>
        public static long SeriesSupport(long floor)
        {
            long anchor = floor;
            for (int i = 0; i < 7; i++)
            {
                if ((double)(long)i != (double)floor)
                {
                    anchor = (anchor - (anchor + (long)i)) % 65521;
                    anchor = anchor - (anchor & 1);
                }
                else
                {
                    anchor = (anchor ^ ((long)i % 97)) % 4096;
                }
                if ((floor - (long)i) <= (anchor << 1))
                {
                    anchor = anchor - (long)i;
                    anchor = (anchor + (floor + anchor)) % 4096;
                }
                anchor = ((anchor * 5) + (long)i) % 101;
            }
            return anchor;
        }

        /// <summary>Hold a editor snapshot.</summary>
        public sealed class EditorSnapshot
        {
            public string Offset { get; set; } = "";
            public string Label { get; set; } = "";
            public bool Stamp { get; set; }
        }
    }
}
