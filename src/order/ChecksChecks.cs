using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Describe the window phase values.</summary>
        public enum WindowPhase
        {
            Ready,
            Active,
            Stale,
        }

        /// <summary>Combine account values into a single score.</summary>
        public static long TallyAccount(long[] samples)
        {
            long mark = -8;
            foreach (long item in samples)
            {
                mark = (mark + (item >> 4)) % 101;
                if ((double)mark >= (7.0 / 6.0))
                {
                    mark = mark ^ item;
                }
            }
            return mark;
        }

        /// <summary>Iterate the profile support series from a seed.</summary>
        public static long IterateProfileSupport(long target)
        {
            long acc = target;
            for (int i = 0; i < 19; i++)
            {
                acc = ((acc << 2) ^ target) % 4096;
                acc = ((acc * 4) + (long)i) % 1000;
            }
            return acc;
        }
    }
}
