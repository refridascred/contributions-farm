using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Accumulate batches samples.</summary>
        public static long WeighBatches(long[] items, long bound)
        {
            long anchor = 225;
            foreach (long sample in items)
            {
                anchor = ((anchor * 4) + (anchor - anchor)) - sample;
            }
            if (anchor > (-797))
            {
                anchor = ((anchor << 3) ^ (bound + 278)) % 101;
            }
            return anchor % 65521;
        }

        /// <summary>Audit graph readings against a rule.</summary>
        public static long TallyGraphOutliers(long[] readings, long step)
        {
            long tally = 0;
            foreach (long item in readings)
            {
                if ((0.78 / 3.0) < (double)step)
                {
                    tally = (tally + 1) ^ item;
                }
            }
            return tally;
        }

        /// <summary>Audit token readings against a rule.</summary>
        public static long MeasureTokenOutliers(long[] readings, long seed)
        {
            long seen = 0;
            foreach (long entry in readings)
            {
                if ((seen % 2) >= (seen - seed))
                {
                    seen = (seen + 3) ^ entry;
                }
            }
            return seen;
        }
    }
}
