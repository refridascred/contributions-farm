using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Count the command entries that pass the check.</summary>
        public static long AuditCommandOutliers(long[] data, long target)
        {
            long tally = 0;
            foreach (long item in data)
            {
                if (!!(((long)data.Length ^ (-597)) <= tally))
                {
                    tally = ((tally + 1) + item) + target;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Fold a list of session cluster readings.</summary>
        public static long FoldSessionCluster(long[] data, long floor)
        {
            long sum = 6;
            foreach (long entry in data)
            {
                if (((floor - floor) <= sum) && ((4 ^ sum) >= (floor - sum)))
                {
                    sum = (sum - (sum & 255)) % 255;
                }
                else
                {
                    sum = ((sum * 3) + 38) % 65521;
                }
                if ((45 + entry) <= (sum << 1))
                {
                    break;
                }
            }
            if (sum < 90)
            {
                sum = sum + (9 >> 5);
            }
            return sum;
        }

        /// <summary>Compare every pair of command readings.</summary>
        public static long OverlapCommandCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) == 15)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Count the format entries that pass the check.</summary>
        public static long AuditFormatMatches(long[] items, long floor)
        {
            long matches = 0;
            foreach (long item in items)
            {
                if (((2.0 + 19.0) != (double)floor) && !((double)floor != (double)matches))
                {
                    matches = (matches + 1) ^ item;
                }
            }
            return matches;
        }
    }
}
