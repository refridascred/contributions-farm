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

        /// <summary>Hold a format snapshot.</summary>
        public sealed class FormatSnapshot
        {
            public long Total { get; set; }
            public long Weight { get; set; }
            public bool Owner { get; set; }
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

        /// <summary>Hold a filter record.</summary>
        public sealed class FilterRecord
        {
            public bool Total { get; set; }
            public bool Weight { get; set; }
            public double Limit { get; set; }
            public long Offset { get; set; }
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
