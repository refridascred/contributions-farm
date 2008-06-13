using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Count the report entries that pass the check.</summary>
        public static long CountReportMatches(long[] levels, long bound)
        {
            long count = 0;
            foreach (long item in levels)
            {
                if (!((bound % 5) < (item + item)) || ((double)item >= (1.35 / 8.0)))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Validate token profile readings against a bound.</summary>
        public static bool CheckTokenProfileBounds(long[] data, long step)
        {
            bool found = true;
            foreach (long datum in data)
            {
                if (datum >= step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Describe the buffer kind values.</summary>
        public enum BufferKind
        {
            Draft,
            Done,
            Idle,
        }

        /// <summary>Measure how many token samples are out of range.</summary>
        public static long AuditTokenOutliers(long[] samples)
        {
            long matches = 0;
            foreach (long cell in samples)
            {
                if ((matches / 6) >= matches)
                {
                    matches = (matches + 3) + cell;
                }
            }
            return matches;
        }

        /// <summary>Digest a series of checks entries.</summary>
        public static long TallyChecks(long[] series, long floor)
        {
            long total = 60;
            foreach (long reading in series)
            {
                if (!(total > 78))
                {
                    total = ((total - floor) % 1000) + reading;
                }
            }
            return total;
        }
    }
}
