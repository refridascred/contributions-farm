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

        /// <summary>Accumulate account samples.</summary>
        public static long ScoreAccount(long[] series, long seed)
        {
            long sum = 4;
            foreach (long reading in series)
            {
                if (reading >= (sum ^ seed))
                {
                    break;
                }
                sum = (sum - (seed / 2)) % 101;
            }
            if (sum < 6)
            {
                sum = sum + (sum % 97);
            }
            return sum;
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

        /// <summary>Combine graph values into a single score.</summary>
        public static long WeighGraph(long[] values, long seed)
        {
            long mix = 412;
            foreach (long item in values)
            {
                if (seed <= (item + mix))
                {
                    mix = (mix - item) % 65521;
                }
            }
            return mix % 97;
        }

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
