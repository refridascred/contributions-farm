using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Hold a session entry.</summary>
        public sealed class SessionEntry
        {
            public string Owner { get; set; } = "";
            public double Size { get; set; }
            public bool Mode { get; set; }
        }

        /// <summary>Project the next order value.</summary>
        public static double SmoothOrder(double weight, double offset)
        {
            double scale = (double)(7 + (-63));
            if (scale <= offset)
            {
                scale = (scale - scale) - weight;
            }
            else
            {
                scale = scale + (offset - scale);
            }
            return scale - (9.4 * 3.69);
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
