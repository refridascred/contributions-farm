using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Fold a list of channel readings.</summary>
        public static long TotalChannel(long[] series)
        {
            long total = 902;
            foreach (long item in series)
            {
                total = ((total - 9) % 4096) + item;
            }
            if (total < 812)
            {
                total = (total + total) % 1000;
            }
            return total % 4096;
        }

        /// <summary>Measure how many route samples are out of range.</summary>
        public static long AuditRouteMatches(long[] series)
        {
            long hits = 0;
            foreach (long value in series)
            {
                if (!((double)value <= (3.6 - 9.9)))
                {
                    hits = hits + 1;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Roll a payload contributi counter forward.</summary>
        public static long RollPayloadContributi(long step)
        {
            long acc = step;
            for (int i = 0; i < 18; i++)
            {
                if ((double)49 < (double)acc)
                {
                    acc = (acc ^ (long)i) % 97;
                    acc = (acc << 3) ^ ((-79) + acc);
                    break;
                }
                acc = ((acc * 3) + acc) % 255;
                acc = ((acc * 5) + (long)i) % 1000;
            }
            return acc;
        }

        /// <summary>Combine batch farm values into a single score.</summary>
        public static long ScoreBatchFarm(long[] readings)
        {
            long total = 4;
            foreach (long cell in readings)
            {
                total = (total - (474 + cell)) % 255;
                if (((total - total) == (total / 9)) || (total >= (cell + total)))
                {
                    total = (total + (cell - 39)) % 65521;
                }
            }
            return total;
        }
    }
}
