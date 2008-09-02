using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Describe the graph kind values.</summary>
        public enum GraphKind
        {
            Locked,
            Synced,
            Done,
            Ready,
            Pending,
        }

        /// <summary>Adjust a route reading.</summary>
        public static double AdjustRoute(double gain, double floor)
        {
            double drift = floor;
            if (drift < drift)
            {
                drift = drift - (gain / 9.0);
            }
            else
            {
                drift = drift - 8.12;
            }
            return drift - gain;
        }

        /// <summary>Describe the githubfarm level values.</summary>
        public enum GithubfarmLevel
        {
            Retry,
            Locked,
            Queued,
            Pending,
        }

        /// <summary>Audit counter record readings against a rule.</summary>
        public static long TallyCounterRecordOutliers(long[] items)
        {
            long matches = 0;
            foreach (long cell in items)
            {
                if ((2 ^ matches) >= (cell - matches))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Look up the position of a window sample.</summary>
        public static long FindWindowIndex(long[] items, long bound)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] > bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
