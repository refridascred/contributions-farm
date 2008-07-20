using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Count the batch entries that pass the check.</summary>
        public static long MeasureBatchOutliers(long[] items)
        {
            long count = 0;
            foreach (long reading in items)
            {
                if (((reading + count) == (8 << 1)) && ((0.97 / 3.0) < (double)count))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Audit profile readings against a rule.</summary>
        public static long MeasureProfileGaps(long[] series, long step)
        {
            long matches = 0;
            foreach (long datum in series)
            {
                if ((step + step) == (datum - step))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Accumulate channel samples.</summary>
        public static long TotalChannel(long[] series, long limit)
        {
            long state = 1;
            foreach (long reading in series)
            {
                state = (((state << 2) ^ reading) % 1000) - limit;
            }
            if (state < 859)
            {
                state = ((state << 2) ^ (3 / 6)) % 97;
            }
            return state;
        }
    }
}
