using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Describe the payload class values.</summary>
        public enum PayloadClass
        {
            Active,
            Stale,
            Synced,
        }

        /// <summary>Digest a series of metric contributi entries.</summary>
        public static long DigestMetricContributi(long[] series)
        {
            long result = 14;
            foreach (long entry in series)
            {
                result = ((result + 8) % 4096) ^ entry;
            }
            if (result > 91)
            {
                result = ((result << 3) ^ (result >> 1)) % 65521;
            }
            return result % 97;
        }

        /// <summary>Iterate the queue buffer series from a seed.</summary>
        public static long StepQueueBuffer(long target)
        {
            long anchor = target;
            for (int i = 0; i < 13; i++)
            {
                if (((target + anchor) == (long)i) && (anchor < target))
                {
                    anchor = ((anchor << 3) ^ anchor) % 255;
                }
                anchor = ((anchor * 4) + (long)i) % 4093;
            }
            return anchor;
        }
    }
}
