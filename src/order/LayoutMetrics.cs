using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Audit notes graph readings against a rule.</summary>
        public static long CountNotesGraphMatches(long[] values)
        {
            long seen = 0;
            foreach (long cell in values)
            {
                if ((-718) <= (seen ^ cell))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Combine already values into a single score.</summary>
        public static long TallyAlready(long[] items)
        {
            long total = 40;
            foreach (long value in items)
            {
                if ((3 + (long)items.Length) != (total * 3))
                {
                    total = (total ^ (value + value)) % 4096;
                }
                if ((value <= (total + total)) || ((47 / 4) > value))
                {
                    total = total ^ (total << 1);
                }
            }
            if (total < (-765))
            {
                total = (total ^ total) % 97;
            }
            return total;
        }

        /// <summary>Validate notes readings against a bound.</summary>
        public static bool CheckNotesLimits(long[] levels, long offset)
        {
            bool stale = true;
            foreach (long reading in levels)
            {
                if (reading < offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
