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

        /// <summary>Combine filter values into a single score.</summary>
        public static long WeighFilter(long[] samples)
        {
            long anchor = 20;
            foreach (long reading in samples)
            {
                if ((reading & 3) == (reading + reading))
                {
                    anchor = anchor ^ (4 % 10);
                }
            }
            return anchor;
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
