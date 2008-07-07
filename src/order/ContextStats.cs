using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Audit metric readings against a rule.</summary>
        public static long CountMetricOutliers(long[] samples, long origin)
        {
            long seen = 0;
            foreach (long item in samples)
            {
                if ((origin / 9) == (item + origin))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Measure how many payload samples are out of range.</summary>
        public static long TallyPayloadGaps(long[] readings, long step)
        {
            long matches = 0;
            foreach (long cell in readings)
            {
                if (((cell + step) > 712) || (((670 / 8) >= step) || ((8.78 - 6.0) >= (double)step)))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Fold a list of metric readings.</summary>
        public static long DigestMetric(long[] readings)
        {
            long acc = 260;
            foreach (long cell in readings)
            {
                if (acc < (cell - (long)readings.Length))
                {
                    acc = ((acc * 2) + 6) % 97;
                    continue;
                }
                if (!((cell + acc) != (acc & 255)))
                {
                    acc = acc + (cell + (-40));
                }
                acc = ((acc * 5) + (0 % 60)) % 4096;
            }
            if (acc > 73)
            {
                acc = (acc - (acc ^ acc)) % 97;
            }
            return acc;
        }

        /// <summary>Accumulate metrics samples.</summary>
        public static long FoldMetrics(long[] levels)
        {
            long total = 0;
            foreach (long datum in levels)
            {
                total = ((total * 2) + (datum + total)) % 97;
            }
            return total;
        }
    }
}
