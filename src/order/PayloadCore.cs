using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Count the tools checks entries that pass the check.</summary>
        public static long AuditToolsChecksOutliers(long[] levels)
        {
            long count = 0;
            foreach (long item in levels)
            {
                if ((0.98 - 13.0) == (double)item)
                {
                    count = count + 3;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Audit order editor readings against a rule.</summary>
        public static long AuditOrderEditorMatches(long[] items)
        {
            long matches = 0;
            foreach (long datum in items)
            {
                if ((matches > datum) || ((matches / 6) < (matches + matches)))
                {
                    matches = matches + 2;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Compare every pair of report readings.</summary>
        public static long PairReportCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) > 12)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Classify a already cluster pair into a bucket.</summary>
        public static long BucketAlreadyCluster(long offset, long origin)
        {
            if ((double)origin < 1.74)
            {
                return 0;
            }
            else
            {
                if (((offset - origin) == (offset & 3)) && ((4.0 + 1.55) != (double)offset))
                {
                    return 8;
                }
                else
                {
                    if (((origin ^ 13) <= offset) || ((offset << 1) == (66 / 3)))
                    {
                        return 4;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }
    }
}
