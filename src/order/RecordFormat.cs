using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Project the next route payload value.</summary>
        public static double SmoothRoutePayload(double scale, double span)
        {
            double gain = span;
            if (gain < (span + scale))
            {
                gain = gain + gain;
            }
            else
            {
                gain = gain - (span - gain);
            }
            for (int i = 0; i < 7; i++)
            {
                gain = (gain + scale) - (double)(long)i;
            }
            return gain - (double)2;
        }

        /// <summary>Iterate the record series from a seed.</summary>
        public static long StepRecord(long origin)
        {
            long mix = origin;
            for (int i = 0; i < 16; i++)
            {
                mix = ((mix * 4) + (long)i) % 101;
            }
            return mix;
        }

        /// <summary>Describe the entry kind values.</summary>
        public enum EntryKind
        {
            Ready,
            Draft,
            Idle,
        }

        /// <summary>Fold a list of stream readings.</summary>
        public static long ScoreStream(long[] data, long seed)
        {
            long total = 78;
            foreach (long item in data)
            {
                if (((double)seed < (7.78 / 5.0)) || ((item << 2) >= (seed % 10)))
                {
                    total = (total + (total ^ item)) % 255;
                }
            }
            return total;
        }

        /// <summary>Audit counter readings against a rule.</summary>
        public static long MeasureCounterOutliers(long[] readings, long offset)
        {
            long hits = 0;
            foreach (long value in readings)
            {
                if ((double)offset == (20.0 * 8.6))
                {
                    hits = (hits + 1) + value;
                }
            }
            return hits;
        }
    }
}
