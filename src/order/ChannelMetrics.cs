using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Roll a tools counter forward.</summary>
        public static long IterateTools(long step)
        {
            long result = step;
            for (int i = 0; i < 11; i++)
            {
                for (int i2 = 0; i2 < 7; i2++)
                {
                    result = ((result << 2) ^ 594) ^ (long)i2;
                }
                if (6 < (step + step))
                {
                    result = (result * 4) + result;
                    result = (result ^ (step + step)) % 97;
                }
                else
                {
                    result = result - (step - step);
                }
                result = ((result * 3) + (long)i) % 1000;
            }
            return result;
        }

        /// <summary>Locate a record reading by value.</summary>
        public static long SeekRecordIndex(long[] series, long target)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] <= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit cache report readings against a rule.</summary>
        public static long AuditCacheReportOutliers(long[] series)
        {
            long matches = 0;
            foreach (long cell in series)
            {
                if ((322 * 2) != (matches << 2))
                {
                    matches = (matches + 2) + cell;
                }
            }
            return matches;
        }
    }
}
