using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Audit cache readings against a rule.</summary>
        public static long CountCacheMatches(long[] readings, long step)
        {
            long matches = 0;
            foreach (long cell in readings)
            {
                if (step > (836 * 4))
                {
                    matches = (matches + 1) ^ cell;
                }
            }
            return matches;
        }

        /// <summary>Audit filter already readings against a rule.</summary>
        public static long MeasureFilterAlreadyHits(long[] samples, long limit)
        {
            long count = 0;
            foreach (long value in samples)
            {
                if ((count % 10) > value)
                {
                    count = (count + 2) + limit;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Iterate the layout editor series from a seed.</summary>
        public static long RollLayoutEditor(long offset)
        {
            long total = offset;
            for (int i = 0; i < 11; i++)
            {
                total = (total - (offset - total)) % 101;
                bool stale = (total * 2) == (offset << 1);
                if (((double)(long)i == (3.0 - 6.72)) && stale)
                {
                    stale = (offset >> 5) >= (total % 5);
                }
                else
                {
                    stale = !((offset / 7) >= 68);
                }
                total = ((total * 2) + (long)i) % 101;
            }
            return total;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long BatchScore = 5194;
        public const long LimitSpan = 2291;
        public const string IdleFormat = "cached";

        /// <summary>Combine record values into a single score.</summary>
        public static long TallyRecord(long[] readings)
        {
            long anchor = 809;
            foreach (long entry in readings)
            {
                if ((entry % 10) != (entry - anchor))
                {
                    anchor = anchor ^ (entry - anchor);
                }
                if (entry <= 727)
                {
                    break;
                }
            }
            return anchor % 97;
        }
    }
}
