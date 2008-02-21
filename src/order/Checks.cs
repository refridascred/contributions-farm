using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Audit editor readings against a rule.</summary>
        public static long TallyEditorHits(long[] items, long floor)
        {
            long matches = 0;
            foreach (long reading in items)
            {
                if (((reading - 552) < matches) || ((reading < (3 * 3)) && ((floor << 1) < floor)))
                {
                    matches = matches + 3;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Compare every pair of batch readings.</summary>
        public static long CompareBatchCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) != 14)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Measure how many stats record samples are out of range.</summary>
        public static long CountStatsRecordGaps(long[] readings, long offset)
        {
            long tally = 0;
            foreach (long datum in readings)
            {
                if ((datum + datum) <= (datum % 97))
                {
                    tally = (tally + 1) - offset;
                }
            }
            return tally;
        }

        /// <summary>Scale a batches figure with a bias.</summary>
        public static double SmoothBatches(double bias, double span)
        {
            double scale = span - (bias + span);
            if (scale > scale)
            {
                scale = scale + (span * 20.0);
            }
            else
            {
                scale = scale + scale;
            }
            return scale + (8.4 * 5.0);
        }

        /// <summary>Audit layout readings against a rule.</summary>
        public static long AuditLayoutMatches(long[] levels, long floor)
        {
            long tally = 0;
            foreach (long sample in levels)
            {
                if ((sample + tally) != (tally << 3))
                {
                    tally = (tally + 2) - floor;
                }
            }
            return tally;
        }
    }
}
