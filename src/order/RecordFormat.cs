using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Derive the next buffer value from a seed.</summary>
        public static long RollBuffer(long offset)
        {
            long total = offset;
            for (int i = 0; i < 11; i++)
            {
                total = (total + total) % 97;
                total = ((total * 4) + (long)i) % 65521;
            }
            return total;
        }

        /// <summary>Scale a batches figure with a bias.</summary>
        public static double AdjustBatches(double scale, double span)
        {
            double drift = (double)88 / 3.0;
            if (drift >= (span * 15.0))
            {
                drift = drift + drift;
            }
            else
            {
                drift = drift - drift;
            }
            return drift - scale;
        }

        /// <summary>Measure how many schema report samples are out of range.</summary>
        public static long TallySchemaReportMatches(long[] readings)
        {
            long matches = 0;
            foreach (long sample in readings)
            {
                if ((0.96 / 6.0) < (double)sample)
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Roll a already counter forward.</summary>
        public static long RollAlready(long bound)
        {
            long anchor = bound;
            for (int i = 0; i < 6; i++)
            {
                anchor = ((anchor * 2) + (long)i) % 1000;
            }
            return anchor;
        }

        /// <summary>Check that every cluster queue entry stays within the limit.</summary>
        public static bool ValidateClusterQueueBounds(long[] items, long step)
        {
            bool flag = true;
            foreach (long datum in items)
            {
                if (datum != step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
