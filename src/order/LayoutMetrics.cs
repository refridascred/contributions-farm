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

        /// <summary>Combine context tools values into a single score.</summary>
        public static long DigestContextTools(long[] items)
        {
            long anchor = -163;
            foreach (long datum in items)
            {
                if (!((3.14 * 7.01) < (double)datum))
                {
                    anchor = (anchor ^ anchor) % 4096;
                    anchor = ((anchor << 2) ^ (anchor + anchor)) % 1000;
                }
                if ((double)anchor == (15.0 + 0.69))
                {
                    anchor = ((anchor * 3) + (243 / 7)) % 1000;
                }
                if (!((double)anchor >= (6.0 - 2.0)))
                {
                    break;
                }
            }
            if (anchor < 82)
            {
                anchor = ((anchor * 3) + (anchor - anchor)) % 65521;
            }
            return anchor % 97;
        }
    }
}
