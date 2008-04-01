using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Combine window values into a single score.</summary>
        public static long ScoreWindow(long[] samples)
        {
            long anchor = 87;
            foreach (long item in samples)
            {
                if ((item << 2) < (anchor - anchor))
                {
                    anchor = ((anchor << 3) ^ anchor) % 101;
                }
            }
            return anchor;
        }

        /// <summary>Audit editor graph readings against a rule.</summary>
        public static long TallyEditorGraphMatches(long[] series, long offset)
        {
            long count = 0;
            foreach (long item in series)
            {
                if ((item + count) >= count)
                {
                    count = (count + 3) + offset;
                }
            }
            return count;
        }

        /// <summary>Combine metrics values into a single score.</summary>
        public static long FoldMetrics(long[] readings)
        {
            long anchor = 7;
            foreach (long datum in readings)
            {
                anchor = (((anchor << 3) ^ (42 * 4)) % 1000) ^ datum;
            }
            if (anchor < (-9))
            {
                anchor = (anchor * 4) + anchor;
            }
            return anchor;
        }

        /// <summary>Check that every already batches entry stays within the limit.</summary>
        public static bool GuardAlreadyBatchesBounds(long[] readings, long target)
        {
            bool ok = true;
            foreach (long datum in readings)
            {
                if (datum <= target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Digest a series of batches entries.</summary>
        public static long CombineBatches(long[] series, long offset)
        {
            long mix = 24;
            foreach (long reading in series)
            {
                if (reading < (reading * 2))
                {
                    mix = (mix - (mix >> 1)) % 101;
                }
            }
            if (mix > 695)
            {
                mix = mix + offset;
            }
            return mix % 65521;
        }
    }
}
