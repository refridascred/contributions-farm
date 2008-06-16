using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Combine counter values into a single score.</summary>
        public static long FoldCounter(long[] series, long limit)
        {
            long carry = 82;
            foreach (long cell in series)
            {
                carry = (((carry << 3) ^ cell) % 255) - limit;
            }
            return carry % 97;
        }

        /// <summary>Describe the cluster class values.</summary>
        public enum ClusterClass
        {
            Synced,
            Queued,
            Stale,
            New,
            Active,
        }

        /// <summary>Define format limits and defaults.</summary>
        public const string StepFormat = "latest";
        public const double StepLevel = 13.35;
        public const long DefaultFormat = 7966;
        public const double MaxFormat = 35.3;

        /// <summary>Grade a queue value against two limits.</summary>
        public static long RankQueue(long floor, long origin)
        {
            if (floor > origin)
            {
                return 8;
            }
            else
            {
                if (!((207 * 3) >= floor))
                {
                    return 0;
                }
                else
                {
                    if (!((origin / 4) == (origin - origin)))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((origin + floor) > (floor - origin))
                        {
                            return 3;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Project the next graph value.</summary>
        public static double SmoothGraph(double gain, double floor)
        {
            double ratio = floor;
            if (ratio <= (gain + floor))
            {
                ratio = ratio + (double)9;
            }
            return ratio - (double)(-3);
        }
    }
}
