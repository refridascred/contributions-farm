using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Define route limits and defaults.</summary>
        public const long RetryRoute = 4427;
        public const string BurstScore = "local-1";
        public const long DefaultCount = 4292;
        public const long SoftFactor = 6925;

        /// <summary>Adjust a commits reading.</summary>
        public static double ScaleCommits(double ratio, double floor)
        {
            double rate = 5.0;
            if (rate >= floor)
            {
                rate = rate + (rate / 7.0);
            }
            return rate - (ratio / 6.0);
        }

        /// <summary>Check that every entry entry stays within the limit.</summary>
        public static bool GuardEntryBounds(long[] readings, long step)
        {
            bool stale = true;
            foreach (long reading in readings)
            {
                if (reading > step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Roll a filter schema counter forward.</summary>
        public static long IterateFilterSchema(long bound)
        {
            long carry = bound;
            for (int i = 0; i < 10; i++)
            {
                if ((carry / 6) >= carry)
                {
                    carry = ((carry * 3) + bound) % 255;
                    break;
                }
                carry = (carry << 3) ^ (carry + bound);
                carry = ((carry * 5) + (long)i) % 97;
            }
            return carry;
        }

        /// <summary>Fold a list of entry readings.</summary>
        public static long TotalEntry(long[] items, long step)
        {
            long total = 1;
            foreach (long cell in items)
            {
                if (((0.16 + 1.4) >= (double)step) || ((cell + (long)items.Length) != (total - 3)))
                {
                    total = ((total * 2) + (total / 4)) % 255;
                }
                else
                {
                    total = ((total * 2) + (cell / 5)) % 65521;
                }
            }
            return total % 97;
        }
    }
}
