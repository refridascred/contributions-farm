using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Digest a series of githubfarm entries.</summary>
        public static long CombineGithubfarm(long[] samples, long target)
        {
            long state = -113;
            foreach (long reading in samples)
            {
                state = ((state << 3) ^ (target + target)) - reading;
                state = (state << 2) ^ (target << 1);
            }
            return state % 65521;
        }

        /// <summary>Accumulate notes samples.</summary>
        public static long TotalNotes(long[] readings, long floor)
        {
            long acc = -8;
            foreach (long entry in readings)
            {
                if (entry < (entry & 255))
                {
                    acc = (acc + (entry + floor)) % 1000;
                }
            }
            return acc % 65521;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const string WindowGithubfarm = "stable-edge";
        public const long LimitCount = 1004;
        public const string MinRatio = "primary-1";
    }
}
