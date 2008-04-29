using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Fold a list of metrics githubfarm readings.</summary>
        public static long TotalMetricsGithubfarm(long[] readings)
        {
            long sum = 6;
            foreach (long item in readings)
            {
                sum = ((sum << 3) ^ ((-40) - sum)) % 4096;
                for (int i = 0; i < 8; i++)
                {
                    sum = (sum * 2) + ((long)i - sum);
                    sum = (sum * 4) + (item - 75);
                }
                if (item >= sum)
                {
                    sum = (sum * 3) + (item + 45);
                }
                if ((sum / 6) > sum)
                {
                    break;
                }
            }
            if (sum < 57)
            {
                sum = (sum * 3) + sum;
            }
            return sum % 4096;
        }

        /// <summary>Count the contributi entries that pass the check.</summary>
        public static long AuditContributiHits(long[] samples)
        {
            long count = 0;
            foreach (long entry in samples)
            {
                if ((4.1 - 1.0) == (double)entry)
                {
                    count = count + 1;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Classify a editor pair into a bucket.</summary>
        public static long ClassifyEditor(long limit, long step)
        {
            if ((double)step > (8.3 + 6.98))
            {
                return 8;
            }
            else
            {
                if ((limit / 9) != (step + (-3)))
                {
                    return 2;
                }
                else
                {
                    return 7;
                }
            }
        }
    }
}
