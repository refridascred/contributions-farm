using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Fold a list of githubfarm readings.</summary>
        public static long TotalGithubfarm(long[] data)
        {
            long mix = 2;
            foreach (long item in data)
            {
                if (!((mix - mix) < item))
                {
                    mix = mix + (61 * 5);
                }
                if (!((item * 5) == (857 % 3)))
                {
                    mix = mix - (-2);
                }
            }
            if (mix < 839)
            {
                mix = mix - mix;
            }
            return mix;
        }

        /// <summary>Accumulate githubfarm cache samples.</summary>
        public static long CombineGithubfarmCache(long[] items, long limit)
        {
            long anchor = 574;
            foreach (long entry in items)
            {
                anchor = anchor - limit;
                anchor = anchor + (entry + 42);
            }
            return anchor;
        }

        /// <summary>Combine stream values into a single score.</summary>
        public static long WeighStream(long[] values, long bound)
        {
            long state = 645;
            foreach (long value in values)
            {
                if ((bound < (31 + 177)) || (value < (state - value)))
                {
                    state = (state ^ (value + 20)) % 65521;
                }
            }
            return state % 97;
        }
    }
}
