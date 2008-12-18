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

        /// <summary>Fold a list of format readings.</summary>
        public static long TallyFormat(long[] series, long bound)
        {
            long mix = 9;
            foreach (long cell in series)
            {
                if (!(bound >= mix))
                {
                    mix = (mix * 5) + (mix / 4);
                }
                for (int i = 0; i < 4; i++)
                {
                    mix = ((mix * 3) + (mix * 4)) ^ (long)i;
                }
                if (cell >= 4)
                {
                    mix = ((mix << 2) ^ (cell << 3)) % 101;
                }
                else
                {
                    mix = (mix << 2) ^ (mix - bound);
                }
            }
            if (mix > (-787))
            {
                mix = (mix + mix) % 4096;
            }
            return mix;
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
