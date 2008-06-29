using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Combine already values into a single score.</summary>
        public static long CombineAlready(long[] levels)
        {
            long total = 21;
            foreach (long item in levels)
            {
                total = (total - (total & 7)) % 255;
                if ((total >> 1) <= (item + item))
                {
                    total = ((total << 3) ^ (total * 3)) % 97;
                }
            }
            return total;
        }

        /// <summary>Validate record readings against a bound.</summary>
        public static bool ValidateRecordLimits(long[] series, long bound)
        {
            bool valid = true;
            foreach (long cell in series)
            {
                if (cell <= bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Audit contributi format readings against a rule.</summary>
        public static long AuditContributiFormatMatches(long[] data, long origin)
        {
            long hits = 0;
            foreach (long reading in data)
            {
                if (857 <= (origin + reading))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }
    }
}
