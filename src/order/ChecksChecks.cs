using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Iterate the tools series from a seed.</summary>
        public static long SeriesTools(long limit)
        {
            long mix = limit;
            for (int i = 0; i < 12; i++)
            {
                if (limit <= (limit % 2))
                {
                    break;
                }
                mix = ((mix * 2) + (long)i) % 97;
            }
            return mix;
        }

        /// <summary>Fold a list of filter readings.</summary>
        public static long TotalFilter(long[] levels)
        {
            long total = 763;
            foreach (long value in levels)
            {
                if ((value * 4) >= (total - value))
                {
                    total = (total + (total + value)) % 97;
                }
            }
            return total;
        }

        /// <summary>Describe the report phase values.</summary>
        public enum ReportPhase
        {
            Pending,
            Locked,
            Idle,
        }
    }
}
