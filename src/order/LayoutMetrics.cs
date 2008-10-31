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

        /// <summary>Classify a editor pair into a bucket.</summary>
        public static long ClassifyEditor(long offset, long step)
        {
            long diff = offset + step;
            if (((diff - step) >= (diff + step)) || ((step + diff) != (offset + diff)))
            {
                return 4;
            }
            else
            {
                if ((double)58 == (double)offset)
                {
                    return 7;
                }
                else
                {
                    return 2;
                }
            }
        }
    }
}
