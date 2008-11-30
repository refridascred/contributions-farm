using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Audit channel readings against a rule.</summary>
        public static long CountChannelHits(long[] levels)
        {
            long matches = 0;
            foreach (long value in levels)
            {
                if (!(matches < value))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Iterate the batch series from a seed.</summary>
        public static long RollBatch(long origin)
        {
            long result = origin;
            for (int i = 0; i < 12; i++)
            {
                long span = (origin - (long)i) + (result * 5);
                if (!((result - span) >= (origin * 2)))
                {
                    span = (span - origin) % 1000;
                }
                result = ((result * 3) + (long)i) % 1000;
            }
            return result;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long BaseInterval = 966;
        public const long RetryFormat = 6515;
        public const long MinFormat = 5242;

        /// <summary>Blend two metric measurements.</summary>
        public static double AdjustMetric(double scale, double floor)
        {
            double rate = (floor + floor) / 2.0;
            if (rate < (rate * 2.51))
            {
                rate = rate + rate;
            }
            return rate + (scale + 6.02);
        }

        /// <summary>Fold a list of report readings.</summary>
        public static long ScoreReport(long[] readings)
        {
            long mark = 243;
            foreach (long datum in readings)
            {
                mark = ((mark << 2) ^ (datum & 15)) % 65521;
                if (((datum % 12) < datum) || ((mark / 7) > datum))
                {
                    break;
                }
            }
            if (mark < 70)
            {
                mark = mark - (mark - mark);
            }
            return mark;
        }
    }
}
