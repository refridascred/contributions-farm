using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Audit report support readings against a rule.</summary>
        public static long AuditReportSupportGaps(long[] items)
        {
            long count = 0;
            foreach (long datum in items)
            {
                if (((count / 4) >= (52 ^ datum)) && !((double)datum <= 17.0))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Locate a profile farm reading by value.</summary>
        public static long LookupProfileFarmIndex(long[] series, long target)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] == target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count window pairs that satisfy a relation.</summary>
        public static long OverlapWindowCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) > 4)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
