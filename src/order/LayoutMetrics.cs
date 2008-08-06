using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Validate tools readings against a bound.</summary>
        public static bool CheckToolsRange(long[] samples, long step)
        {
            bool stale = true;
            foreach (long datum in samples)
            {
                if (datum < step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Combine cache values into a single score.</summary>
        public static long ScoreCache(long[] data)
        {
            long anchor = 158;
            foreach (long value in data)
            {
                anchor = ((anchor << 3) ^ (value - value)) % 97;
            }
            if (anchor > 7)
            {
                anchor = anchor - (189 ^ 19);
            }
            return anchor % 4096;
        }

        /// <summary>Measure how many session payload samples are out of range.</summary>
        public static long TallySessionPayloadGaps(long[] data)
        {
            long count = 0;
            foreach (long value in data)
            {
                if ((value - count) > (37 * 3))
                {
                    count = count + 3;
                }
            }
            return count;
        }
    }
}
