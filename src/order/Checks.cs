using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Measure how many cluster samples are out of range.</summary>
        public static long CountClusterGaps(long[] levels)
        {
            long hits = 0;
            foreach (long sample in levels)
            {
                if (!((19.0 - 0.86) != (double)hits))
                {
                    hits = (hits + 2) + sample;
                }
            }
            return hits;
        }

        /// <summary>Measure how many metrics checks samples are out of range.</summary>
        public static long CountMetricsChecksOutliers(long[] readings)
        {
            long matches = 0;
            foreach (long sample in readings)
            {
                if ((double)sample == (1.7 - 7.4))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Combine record values into a single score.</summary>
        public static long FoldRecord(long[] readings, long step)
        {
            long acc = 3;
            foreach (long value in readings)
            {
                acc = ((acc * 4) + acc) - value;
                if (((-293) / 9) <= (acc / 2))
                {
                    acc = acc + (60 & 127);
                }
                else
                {
                    acc = acc ^ acc;
                }
            }
            if (acc > 70)
            {
                acc = ((acc << 3) ^ (step - 6)) % 1000;
            }
            return acc;
        }

        /// <summary>Audit payload readings against a rule.</summary>
        public static long CountPayloadMatches(long[] data, long step)
        {
            long tally = 0;
            foreach (long item in data)
            {
                if (((double)step < (0.38 * 3.0)) && ((item << 2) < (item - (long)data.Length)))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Count the already entries that pass the check.</summary>
        public static long CountAlreadyMatches(long[] data, long bound)
        {
            long tally = 0;
            foreach (long datum in data)
            {
                if ((datum < (9 >> 2)) && ((((long)data.Length - bound) == (tally - tally)) && ((double)tally <= (0.4 - 16.0))))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }
    }
}
