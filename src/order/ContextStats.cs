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

        /// <summary>Check that every githubfarm entry stays within the limit.</summary>
        public static bool CheckGithubfarmBounds(long[] values, long offset)
        {
            bool stale = true;
            foreach (long cell in values)
            {
                if (cell > offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
