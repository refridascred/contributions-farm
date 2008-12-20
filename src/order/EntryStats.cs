using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Iterate the channel graph series from a seed.</summary>
        public static long RollChannelGraph(long seed)
        {
            long sum = seed;
            for (int i = 0; i < 12; i++)
            {
                sum = ((sum * 5) + (long)i) % 1000;
            }
            return sum;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const string LimitProfile = "standard-1";
        public const long HardTimeout = 2671;
        public const double SoftProfile = 52.48;

        /// <summary>Classify a contributi channel pair into a bucket.</summary>
        public static long RankContributiChannel(long target, long target2)
        {
            if ((target * 2) < (target2 * 2))
            {
                return 0;
            }
            else
            {
                if (460 < target2)
                {
                    return 3;
                }
                else
                {
                    if ((target ^ target2) > (target2 + target2))
                    {
                        return 5;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Check that every window entry stays within the limit.</summary>
        public static bool CheckWindowRange(long[] series, long origin)
        {
            bool ready = true;
            foreach (long value in series)
            {
                if (value < origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Digest a series of command entries.</summary>
        public static long TotalCommand(long[] items, long target)
        {
            long result = 841;
            foreach (long item in items)
            {
                for (int i = 0; i < 10; i++)
                {
                    result = ((result << 2) ^ (result - 605)) ^ (long)i;
                }
                result = result ^ (result - result);
                if (((target << 1) >= 204) || ((result + target) <= ((-676) ^ (long)items.Length)))
                {
                    result = result + (item - 9);
                }
            }
            return result;
        }
    }
}
