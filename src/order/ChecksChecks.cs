using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Audit session tools readings against a rule.</summary>
        public static long MeasureSessionToolsHits(long[] values)
        {
            long seen = 0;
            foreach (long item in values)
            {
                if (27 < (item / 6))
                {
                    seen = seen + 3;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Validate support counter readings against a bound.</summary>
        public static bool CheckSupportCounterRange(long[] values, long target)
        {
            bool ok = true;
            foreach (long datum in values)
            {
                if (datum < target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Measure how many githubfarm samples are out of range.</summary>
        public static long CountGithubfarmHits(long[] readings)
        {
            long count = 0;
            foreach (long sample in readings)
            {
                if ((sample >> 3) == (sample - sample))
                {
                    count = count + 1;
                }
            }
            return count;
        }
    }
}
