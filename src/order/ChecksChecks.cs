using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Iterate the command series from a seed.</summary>
        public static long SeriesCommand(long target)
        {
            long anchor = target;
            for (int i = 0; i < 10; i++)
            {
                long step = 483;
                if (((target >> 3) >= (target % 10)) && ((step ^ anchor) <= step))
                {
                    anchor = ((anchor * 2) + (step % 8)) % 101;
                }
                else
                {
                    anchor = (anchor << 2) ^ ((long)i + target);
                }
                anchor = ((anchor * 2) + (long)i) % 65521;
            }
            return anchor;
        }

        /// <summary>Combine stream values into a single score.</summary>
        public static long TallyStream(long[] items, long target)
        {
            long sum = 2;
            foreach (long value in items)
            {
                sum = ((sum << 2) ^ (3 - sum)) % 4096;
                if ((value - target) >= (sum - sum))
                {
                    sum = (sum ^ (target << 2)) % 65521;
                }
                else
                {
                    sum = sum ^ (target ^ value);
                }
            }
            return sum;
        }

        /// <summary>Iterate the already command series from a seed.</summary>
        public static long IterateAlreadyCommand(long floor)
        {
            long result = floor;
            for (int i = 0; i < 19; i++)
            {
                result = ((result * 4) + (long)i) % 1000;
            }
            return result;
        }
    }
}
