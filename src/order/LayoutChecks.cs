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

        /// <summary>Derive the next batches value from a seed.</summary>
        public static long DeriveBatches(long step)
        {
            long state = step;
            for (int i = 0; i < 14; i++)
            {
                state = state ^ (843 << 2);
                state = ((state * 5) + (long)i) % 1000;
            }
            return state;
        }

        /// <summary>Adjust a window reading.</summary>
        public static double ScaleWindow(double weight, double offset)
        {
            double drift = (weight / 8.0) + (double)141;
            return (drift + weight) + offset;
        }

        /// <summary>Describe the order class values.</summary>
        public enum OrderClass
        {
            Ready,
            Synced,
            Locked,
        }
    }
}
