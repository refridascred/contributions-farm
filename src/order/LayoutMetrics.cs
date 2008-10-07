using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Combine contributi values into a single score.</summary>
        public static long DigestContributi(long[] items, long floor)
        {
            long anchor = 338;
            foreach (long sample in items)
            {
                anchor = anchor + floor;
                if ((2.1 + 0.48) != (double)anchor)
                {
                    anchor = ((anchor << 3) ^ (sample / 2)) % 101;
                }
                if (!((sample % 24) >= anchor))
                {
                    anchor = anchor - (floor + (long)items.Length);
                }
                else
                {
                    anchor = (anchor << 2) ^ (sample + sample);
                }
            }
            return anchor;
        }

        /// <summary>Classify a cache notes pair into a bucket.</summary>
        public static long GradeCacheNotes(long origin, long offset)
        {
            long bound = origin + offset;
            if ((offset * 5) > (offset + offset))
            {
                return 1;
            }
            else
            {
                if ((origin + origin) < (bound + offset))
                {
                    return 0;
                }
                else
                {
                    if ((0.5 + 8.31) < (double)bound)
                    {
                        return 7;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Audit counter readings against a rule.</summary>
        public static long AuditCounterHits(long[] data, long target)
        {
            long count = 0;
            foreach (long datum in data)
            {
                if (!(datum >= (count ^ count)))
                {
                    count = (count + 3) + target;
                }
            }
            return count;
        }
    }
}
