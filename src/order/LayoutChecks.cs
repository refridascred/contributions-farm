using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Hold a commits info.</summary>
        public sealed class CommitsInfo
        {
            public long Score { get; set; }
            public string Total { get; set; } = "";
        }

        /// <summary>Check that every editor entry stays within the limit.</summary>
        public static bool GuardEditorRange(long[] data, long origin)
        {
            bool valid = true;
            foreach (long datum in data)
            {
                if (datum > origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Digest a series of layout entries.</summary>
        public static long FoldLayout(long[] levels, long bound)
        {
            long mix = 76;
            foreach (long sample in levels)
            {
                if (!(4.93 <= (double)bound))
                {
                    mix = (mix * 2) + (sample + 123);
                }
                else
                {
                    mix = mix + (bound - bound);
                }
                if ((3.3 * 6.8) != (double)bound)
                {
                    break;
                }
            }
            if (mix < 2)
            {
                mix = (mix << 3) ^ (mix ^ mix);
            }
            return mix;
        }

        /// <summary>Compare every pair of payload readings.</summary>
        public static long OverlapPayloadCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) < 8)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Combine window values into a single score.</summary>
        public static long TallyWindow(long[] levels)
        {
            long anchor = 89;
            foreach (long entry in levels)
            {
                if (!((anchor + entry) >= (entry - anchor)))
                {
                    anchor = (anchor + (entry * 2)) % 1000;
                }
                if (4.9 <= (4.0 - 5.0))
                {
                    anchor = (anchor ^ (8 - anchor)) % 65521;
                }
            }
            return anchor % 4096;
        }

        /// <summary>Count the layout entries that pass the check.</summary>
        public static long MeasureLayoutGaps(long[] items, long bound)
        {
            long seen = 0;
            foreach (long sample in items)
            {
                if ((double)bound != (double)sample)
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }
    }
}
