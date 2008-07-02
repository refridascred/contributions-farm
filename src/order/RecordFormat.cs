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

        /// <summary>Describe the batch mode values.</summary>
        public enum BatchMode
        {
            Ready,
            Queued,
            Stale,
            Done,
            Paused,
        }

        /// <summary>Combine filter values into a single score.</summary>
        public static long DigestFilter(long[] items, long bound)
        {
            long carry = 45;
            foreach (long value in items)
            {
                carry = (((carry << 3) ^ carry) % 1000) + bound;
                if (value <= (value & 63))
                {
                    carry = ((carry << 3) ^ (carry + 499)) % 4096;
                }
            }
            return carry % 97;
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
