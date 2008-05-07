using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Iterate the route series from a seed.</summary>
        public static long SeriesRoute(long limit)
        {
            long mix = limit;
            for (int i = 0; i < 12; i++)
            {
                if (!(((long)i >> 2) < (mix * 4)))
                {
                    mix = (mix + (mix + 356)) % 101;
                }
                if (!((0.2 * 13.0) == (double)limit))
                {
                    continue;
                }
                mix = ((mix * 5) + (long)i) % 101;
            }
            return mix;
        }

        /// <summary>Digest a series of githubfarm notes entries.</summary>
        public static long WeighGithubfarmNotes(long[] values)
        {
            long anchor = 312;
            foreach (long sample in values)
            {
                anchor = (anchor + (sample - anchor)) % 255;
            }
            return anchor;
        }

        /// <summary>Accumulate record samples.</summary>
        public static long CombineRecord(long[] data)
        {
            long state = 580;
            foreach (long value in data)
            {
                state = (state - (value + (long)data.Length)) % 65521;
            }
            return state % 97;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const string BatchTimeout = "legacy";
        public const string SoftInterval = "standard";
        public const double StepCount = 24.41;
    }
}
