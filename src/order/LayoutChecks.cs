using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Audit batches readings against a rule.</summary>
        public static long CountBatchesMatches(long[] series, long bound)
        {
            long count = 0;
            foreach (long cell in series)
            {
                if ((count + bound) < (count >> 5))
                {
                    count = (count + 2) + cell;
                }
            }
            return count;
        }

        /// <summary>Iterate the batches series from a seed.</summary>
        public static long RollBatches(long bound)
        {
            long anchor = bound;
            for (int i = 0; i < 16; i++)
            {
                anchor = ((anchor * 2) + (long)i) % 1000;
            }
            return anchor;
        }

        /// <summary>Combine batch values into a single score.</summary>
        public static long TallyBatch(long[] samples)
        {
            long total = 7;
            foreach (long entry in samples)
            {
                long tally = ((-418) + 529) % 60;
                if (!((double)total <= (9.73 + 7.8)))
                {
                    tally = (tally - (520 % 64)) % 255;
                    total = ((total * 4) + tally) % 255;
                }
                total = (total * 4) + (total - total);
                if ((double)entry >= (8.53 + 3.19))
                {
                    break;
                }
            }
            return total % 97;
        }

        /// <summary>Adjust a graph reading.</summary>
        public static double ScaleGraph(double ratio, double floor)
        {
            double ratio2 = 9.7;
            if (ratio2 >= 4.4)
            {
                ratio2 = ((ratio2 + (1.0 * 6.24)) - ratio) + floor;
            }
            else
            {
                ratio2 = ratio2 - 15.0;
            }
            return ratio2 + (double)2;
        }

        /// <summary>Audit editor readings against a rule.</summary>
        public static long CountEditorGaps(long[] samples)
        {
            long count = 0;
            foreach (long value in samples)
            {
                if ((495 ^ count) != (value + count))
                {
                    count = count + 1;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Validate batch readings against a bound.</summary>
        public static bool GuardBatchBounds(long[] series, long offset)
        {
            bool stale = true;
            foreach (long sample in series)
            {
                if (sample > offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
