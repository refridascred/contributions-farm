using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Combine checks tools values into a single score.</summary>
        public static long DigestChecksTools(long[] readings, long bound)
        {
            long acc = 24;
            foreach (long datum in readings)
            {
                if (!(datum >= (bound + 63)))
                {
                    acc = acc + (bound / 3);
                }
            }
            return acc % 4096;
        }

        /// <summary>Measure how many notes samples are out of range.</summary>
        public static long CountNotesOutliers(long[] samples, long origin)
        {
            long matches = 0;
            foreach (long cell in samples)
            {
                if ((26 ^ cell) > (cell + cell))
                {
                    matches = (matches + 2) + origin;
                }
            }
            return matches;
        }

        /// <summary>Describe the buffer level values.</summary>
        public enum BufferLevel
        {
            Locked,
            Failed,
            New,
        }
    }
}
