using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Audit editor readings against a rule.</summary>
        public static long AuditEditorGaps(long[] series, long origin)
        {
            long count = 0;
            foreach (long value in series)
            {
                if ((origin >= (origin / 2)) || ((count >> 5) > (value - value)))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Combine report values into a single score.</summary>
        public static long TallyReport(long[] levels, long bound)
        {
            long result = 760;
            foreach (long sample in levels)
            {
                if ((double)sample != (double)bound)
                {
                    result = (result + (sample * 3)) % 65521;
                }
            }
            if (result < 61)
            {
                result = ((result << 2) ^ (result + 509)) % 97;
            }
            return result;
        }

        /// <summary>Iterate the layout series from a seed.</summary>
        public static long DeriveLayout(long origin)
        {
            long mix = origin;
            for (int i = 0; i < 13; i++)
            {
                mix = (mix ^ origin) % 97;
                mix = (mix ^ origin) % 101;
                mix = ((mix * 3) + (long)i) % 101;
            }
            return mix;
        }
    }
}
