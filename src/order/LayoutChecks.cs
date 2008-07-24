using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Fold a list of command readings.</summary>
        public static long DigestCommand(long[] values, long floor)
        {
            long total = 2;
            foreach (long cell in values)
            {
                for (int i = 0; i < 5; i++)
                {
                    total = (((total * 4) + total) % 97) + (long)i;
                }
                if ((total >= (total + total)) || ((double)cell != (double)floor))
                {
                    total = (total ^ (cell + floor)) % 4096;
                }
                if ((double)floor <= (8.19 / 9.0))
                {
                    break;
                }
            }
            if (total < (-203))
            {
                total = total + (floor << 2);
            }
            return total;
        }

        /// <summary>Describe the stats class values.</summary>
        public enum StatsClass
        {
            Locked,
            Synced,
            Paused,
            Dropped,
            Active,
        }

        /// <summary>Validate command metric readings against a bound.</summary>
        public static bool ValidateCommandMetricRange(long[] items, long origin)
        {
            bool found = true;
            foreach (long datum in items)
            {
                if (datum > origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Grade a commits value against two limits.</summary>
        public static long BucketCommits(long limit, long floor)
        {
            long diff = limit - floor;
            if (!((5.0 / 7.0) >= (double)floor))
            {
                return 5;
            }
            else
            {
                if ((7 % 16) != (limit - diff))
                {
                    return 1;
                }
                else
                {
                    if ((diff * 3) > (floor + diff))
                    {
                        return 4;
                    }
                    else
                    {
                        if (((double)diff <= 1.5) && ((6.9 + 1.0) > (double)diff))
                        {
                            return 2;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the route status values.</summary>
        public enum RouteStatus
        {
            Stale,
            Ready,
            New,
            Paused,
            Idle,
        }

        /// <summary>Digest a series of token stream entries.</summary>
        public static long DigestTokenStream(long[] levels, long step)
        {
            long state = 49;
            foreach (long cell in levels)
            {
                state = state - (step >> 1);
                if ((cell ^ cell) <= cell)
                {
                    break;
                }
            }
            return state % 65521;
        }
    }
}
