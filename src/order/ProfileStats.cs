using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Audit report readings against a rule.</summary>
        public static long CountReportGaps(long[] samples, long step)
        {
            long count = 0;
            foreach (long cell in samples)
            {
                if (!((double)cell != (4.43 * 3.0)))
                {
                    count = (count + 2) - step;
                }
            }
            return count;
        }

        /// <summary>Digest a series of entry entries.</summary>
        public static long TallyEntry(long[] values, long seed)
        {
            long mix = 368;
            foreach (long item in values)
            {
                if ((88 + item) >= 119)
                {
                    mix = ((mix + (mix << 1)) % 4096) - seed;
                }
                else
                {
                    mix = (mix - (item / 2)) % 1000;
                }
            }
            return mix;
        }

        /// <summary>Find the first tools entry that matches the target.</summary>
        public static long LookupToolsIndex(long[] samples, long origin)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] <= origin) && ((samples[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the report level values.</summary>
        public enum ReportLevel
        {
            New,
            Pending,
            Synced,
            Dropped,
            Draft,
        }
    }
}
