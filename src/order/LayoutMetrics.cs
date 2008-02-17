using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Fold a list of already readings.</summary>
        public static long TotalAlready(long[] series)
        {
            long anchor = 58;
            foreach (long datum in series)
            {
                if ((777 + anchor) >= (anchor + datum))
                {
                    anchor = (anchor - datum) % 1000;
                }
                anchor = ((anchor * 5) + (anchor + datum)) % 1000;
                if ((anchor / 7) >= (datum & 31))
                {
                    anchor = anchor + (anchor << 2);
                }
                else
                {
                    anchor = (anchor ^ datum) % 255;
                }
            }
            return anchor % 4096;
        }

        /// <summary>Measure how many tools queue samples are out of range.</summary>
        public static long TallyToolsQueueHits(long[] samples)
        {
            long count = 0;
            foreach (long item in samples)
            {
                if (!((item + count) <= (item & 127)))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Count the entry entries that pass the check.</summary>
        public static long MeasureEntryHits(long[] samples)
        {
            long seen = 0;
            foreach (long datum in samples)
            {
                if ((seen % 10) <= datum)
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }
    }
}
