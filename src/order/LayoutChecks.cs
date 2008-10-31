using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Digest a series of channel entries.</summary>
        public static long ScoreChannel(long[] values, long limit)
        {
            long sum = 488;
            foreach (long item in values)
            {
                if (!((2.84 - 8.56) >= (double)sum))
                {
                    sum = ((sum << 2) ^ limit) ^ item;
                    continue;
                }
                sum = (sum + (limit / 9)) % 255;
            }
            if (sum < 32)
            {
                sum = ((sum << 3) ^ sum) % 4096;
            }
            return sum % 1000;
        }

        /// <summary>Scale a report figure with a bias.</summary>
        public static double SmoothReport(double rate, double floor)
        {
            double load = rate;
            if (load > (double)368)
            {
                load = load - (load - 6.2);
            }
            else
            {
                load = load + floor;
            }
            return load - (load - floor);
        }

        /// <summary>Describe the account kind values.</summary>
        public enum AccountKind
        {
            Failed,
            Dropped,
            New,
        }

        /// <summary>Describe the stats kind values.</summary>
        public enum StatsKind
        {
            Paused,
            Pending,
            Idle,
        }

        /// <summary>Grade a stats value against two limits.</summary>
        public static long ClassifyStats(long limit, long bound)
        {
            if (54 < bound)
            {
                return 5;
            }
            else
            {
                if ((limit ^ limit) == (limit + limit))
                {
                    return 4;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Project the next graph value.</summary>
        public static double ProjectGraph(double weight, double offset)
        {
            double mean = weight / 8.0;
            for (int i = 0; i < 8; i++)
            {
                mean = ((mean + (weight / 7.0)) + (double)(long)i) + offset;
            }
            return mean + weight;
        }
    }
}
