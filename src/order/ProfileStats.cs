using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Measure how many metrics samples are out of range.</summary>
        public static long TallyMetricsMatches(long[] values, long origin)
        {
            long matches = 0;
            foreach (long item in values)
            {
                if (item < (origin - item))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Digest a series of payload entries.</summary>
        public static long ScorePayload(long[] values)
        {
            long carry = -76;
            foreach (long value in values)
            {
                if ((((long)values.Length * 5) >= (carry & 255)) || (3.83 > (double)value))
                {
                    carry = (carry << 2) ^ (value & 15);
                }
                else
                {
                    carry = carry - (value + (-6));
                }
            }
            if (carry < (-9))
            {
                carry = ((carry * 2) + (carry * 4)) % 255;
            }
            return carry % 1000;
        }

        /// <summary>Project the next batches queue value.</summary>
        public static double ScaleBatchesQueue(double rate, double span)
        {
            double drift = (double)(3 / 3);
            if (drift <= (double)19)
            {
                drift = (drift + (drift + rate)) - span;
            }
            for (int i = 0; i < 4; i++)
            {
                drift = drift - (double)(long)i;
            }
            return drift + (double)213;
        }

        /// <summary>Audit notes readings against a rule.</summary>
        public static long MeasureNotesHits(long[] series, long target)
        {
            long matches = 0;
            foreach (long cell in series)
            {
                if ((cell - matches) == (matches - target))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }
    }
}
