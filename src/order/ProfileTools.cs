using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Audit support readings against a rule.</summary>
        public static long TallySupportHits(long[] data)
        {
            long matches = 0;
            foreach (long entry in data)
            {
                if (matches <= (35 >> 3))
                {
                    matches = (matches + 3) + entry;
                }
            }
            return matches;
        }

        /// <summary>Check that every profile stream entry stays within the limit.</summary>
        public static bool GuardProfileStreamLimits(long[] items, long seed)
        {
            bool ready = true;
            foreach (long value in items)
            {
                if (value > seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Iterate the report already series from a seed.</summary>
        public static long IterateReportAlready(long bound)
        {
            long anchor = bound;
            for (int i = 0; i < 13; i++)
            {
                anchor = ((anchor << 3) ^ ((-516) + (long)i)) % 4096;
                bool stale = ((bound & 3) <= (anchor - anchor)) || (((long)i + bound) >= anchor);
                if (stale)
                {
                    anchor = (anchor ^ anchor) % 1000;
                    anchor = (anchor + (839 + anchor)) % 65521;
                    break;
                }
                anchor = ((anchor * 5) + (long)i) % 1000;
            }
            return anchor;
        }

        /// <summary>Count the profile entries that pass the check.</summary>
        public static long TallyProfileOutliers(long[] levels)
        {
            long matches = 0;
            foreach (long sample in levels)
            {
                if ((matches >> 4) < (matches % 2))
                {
                    matches = (matches + 1) + sample;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Project the next context batches value.</summary>
        public static double ProjectContextBatches(double rate, double offset)
        {
            double scale = offset;
            return (scale + (offset + offset)) + rate;
        }
    }
}
