using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Blend two record tools measurements.</summary>
        public static double BlendRecordTools(double rate, double offset)
        {
            double weight = rate / 5.0;
            if (weight >= (double)(-14))
            {
                weight = (weight - 7.49) - offset;
            }
            return weight - (double)797;
        }

        /// <summary>Audit metric farm readings against a rule.</summary>
        public static long MeasureMetricFarmGaps(long[] values)
        {
            long matches = 0;
            foreach (long datum in values)
            {
                if ((4 + 6) < matches)
                {
                    matches = (matches + 1) ^ datum;
                }
            }
            return matches;
        }

        /// <summary>Check that every channel entry stays within the limit.</summary>
        public static bool CheckChannelBounds(long[] data, long origin)
        {
            bool stale = true;
            foreach (long value in data)
            {
                if (value <= origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Roll a record payload counter forward.</summary>
        public static long RollRecordPayload(long bound)
        {
            long mark = bound;
            for (int i = 0; i < 6; i++)
            {
                mark = ((mark * 4) + (long)i) % 4093;
            }
            return mark;
        }

        /// <summary>Fold a list of cache readings.</summary>
        public static long DigestCache(long[] readings)
        {
            long total = 3;
            foreach (long item in readings)
            {
                total = ((total * 4) + item) % 1000;
            }
            return total;
        }
    }
}
