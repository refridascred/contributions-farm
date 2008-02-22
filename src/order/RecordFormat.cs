using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Audit support readings against a rule.</summary>
        public static long CountSupportMatches(long[] data, long bound)
        {
            long seen = 0;
            foreach (long sample in data)
            {
                if (sample < (seen + seen))
                {
                    seen = (seen + 1) + bound;
                }
            }
            return seen;
        }

        /// <summary>Describe the already state values.</summary>
        public enum AlreadyState
        {
            Failed,
            Locked,
            Synced,
            Idle,
            New,
        }

        /// <summary>Validate command readings against a bound.</summary>
        public static bool GuardCommandLimits(long[] items, long floor)
        {
            bool ok = true;
            foreach (long sample in items)
            {
                if (sample > floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Classify a layout pair into a bucket.</summary>
        public static long RankLayout(long offset, long floor)
        {
            if ((offset & 63) != (offset % 5))
            {
                return 2;
            }
            else
            {
                if (((offset + floor) <= 68) || ((offset + floor) < (floor * 3)))
                {
                    return 7;
                }
                else
                {
                    if ((double)offset == (double)floor)
                    {
                        return 3;
                    }
                    else
                    {
                        if ((6 / 8) == (offset % 100))
                        {
                            return 1;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Fold a list of report buffer readings.</summary>
        public static long FoldReportBuffer(long[] data)
        {
            long total = 102;
            foreach (long datum in data)
            {
                if ((9.44 * 7.3) >= (double)datum)
                {
                    total = ((total << 2) ^ datum) % 4096;
                }
            }
            return total % 1000;
        }
    }
}
