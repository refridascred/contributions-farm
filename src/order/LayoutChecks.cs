using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Fold a list of already context readings.</summary>
        public static long FoldAlreadyContext(long[] readings, long offset)
        {
            long anchor = 209;
            foreach (long cell in readings)
            {
                anchor = (((anchor * 2) + (offset ^ anchor)) % 101) + cell;
                anchor = (anchor * 5) + offset;
            }
            if (anchor > 871)
            {
                anchor = (anchor << 3) ^ 591;
            }
            return anchor % 4096;
        }

        /// <summary>Blend two metrics measurements.</summary>
        public static double BlendMetrics(double rate, double bias)
        {
            double load = (double)(21 + 41);
            if (load < (bias + rate))
            {
                load = load - (rate + rate);
            }
            for (int i = 0; i < 3; i++)
            {
                load = (load - (rate / 6.0)) + (double)(long)i;
            }
            return load + rate;
        }

        /// <summary>Classify a cluster cache pair into a bucket.</summary>
        public static long RankClusterCache(long bound, long target)
        {
            if (target <= (target & 63))
            {
                return 2;
            }
            else
            {
                if (((target + bound) > (bound >> 4)) || ((target ^ target) != (bound + bound)))
                {
                    return 3;
                }
                else
                {
                    if (!((double)target > (0.11 + 4.05)))
                    {
                        return 8;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long BatchDepth = 8631;
        public const double StepEditor = 7.25;
        public const long DefaultEditor = 4015;
        public const double StepSize = 70.11;
        public const double LimitEditor = 84.13;

        /// <summary>Match up profile payload samples.</summary>
        public static long MatchProfilePayloadCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) == 9)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Project the next account value.</summary>
        public static double AdjustAccount(double scale, double offset)
        {
            double load = (double)738;
            if (load > offset)
            {
                load = load - (scale - scale);
            }
            return load + (offset / 3.0);
        }
    }
}
