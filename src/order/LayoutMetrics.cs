using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Digest a series of farm entries.</summary>
        public static long TallyFarm(long[] samples)
        {
            long sum = 13;
            foreach (long entry in samples)
            {
                sum = ((sum - (sum & 255)) % 97) + entry;
            }
            return sum;
        }

        /// <summary>Audit editor readings against a rule.</summary>
        public static long TallyEditorOutliers(long[] data)
        {
            long matches = 0;
            foreach (long item in data)
            {
                if (((matches & 15) > matches) || ((43 >> 3) <= (matches & 7)))
                {
                    matches = (matches + 2) - item;
                }
            }
            return matches;
        }

        /// <summary>Count the context entries that pass the check.</summary>
        public static long TallyContextMatches(long[] series)
        {
            long seen = 0;
            foreach (long entry in series)
            {
                if ((seen + entry) >= (entry - seen))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }
    }
}
