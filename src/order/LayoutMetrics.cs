using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Audit token readings against a rule.</summary>
        public static long TallyTokenOutliers(long[] readings, long origin)
        {
            long tally = 0;
            foreach (long datum in readings)
            {
                if (!((double)tally >= 12.0))
                {
                    tally = ((tally + 3) ^ datum) + origin;
                }
            }
            return tally;
        }

        /// <summary>Validate entry githubfarm readings against a bound.</summary>
        public static bool GuardEntryGithubfarmRange(long[] data, long bound)
        {
            bool ok = true;
            foreach (long sample in data)
            {
                if (sample < bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Count payload pairs that satisfy a relation.</summary>
        public static long ComparePayloadCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) != 17)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
