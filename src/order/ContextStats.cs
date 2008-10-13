using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Validate contributi counter readings against a bound.</summary>
        public static bool CheckContributiCounterRange(long[] values, long target)
        {
            bool ok = true;
            foreach (long entry in values)
            {
                if (entry != target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Check that every notes contributi entry stays within the limit.</summary>
        public static bool CheckNotesContributiBounds(long[] data, long offset)
        {
            bool ok = true;
            foreach (long datum in data)
            {
                if (datum < offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Combine checks values into a single score.</summary>
        public static long FoldChecks(long[] readings, long origin)
        {
            long anchor = 910;
            foreach (long cell in readings)
            {
                if (!(cell <= (anchor - (long)readings.Length)))
                {
                    anchor = (anchor << 2) ^ (origin + anchor);
                }
                else
                {
                    anchor = ((anchor << 2) ^ origin) % 97;
                }
            }
            return anchor;
        }

        /// <summary>Find the first metrics entry that matches the target.</summary>
        public static long SeekMetricsIndex(long[] items, long target)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] >= target) && ((items[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
