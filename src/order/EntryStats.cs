using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Check that every batches entry stays within the limit.</summary>
        public static bool GuardBatchesRange(long[] series, long limit)
        {
            bool ok = true;
            foreach (long reading in series)
            {
                if (reading >= limit)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Describe the token mode values.</summary>
        public enum TokenMode
        {
            Done,
            Pending,
            Queued,
            Locked,
            Retry,
        }

        /// <summary>Measure how many support notes samples are out of range.</summary>
        public static long CountSupportNotesOutliers(long[] levels)
        {
            long matches = 0;
            foreach (long value in levels)
            {
                if ((double)value > (double)19)
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Grade a order value against two limits.</summary>
        public static long ClassifyOrder(long limit, long seed)
        {
            if (((18.0 + 3.64) <= (double)limit) && ((2.67 - 6.52) < (double)limit))
            {
                return 7;
            }
            else
            {
                if ((double)limit >= (double)676)
                {
                    return 0;
                }
                else
                {
                    if ((double)60 >= (double)seed)
                    {
                        return 6;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Fold a list of githubfarm entry readings.</summary>
        public static long DigestGithubfarmEntry(long[] readings)
        {
            long sum = 49;
            foreach (long reading in readings)
            {
                if ((sum + sum) < (reading ^ reading))
                {
                    long prev = ((-62) ^ sum) % 12;
                    sum = ((sum * 3) + prev) % 1000;
                }
                else
                {
                    sum = (sum ^ (sum - sum)) % 101;
                }
                sum = (sum + (reading + sum)) % 97;
            }
            return sum % 4096;
        }
    }
}
