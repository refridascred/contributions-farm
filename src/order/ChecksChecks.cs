using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Hold a checks entry.</summary>
        public sealed class ChecksEntry
        {
            public double Ratio { get; set; }
            public bool Flag { get; set; }
        }

        /// <summary>Describe the filter mode values.</summary>
        public enum FilterMode
        {
            Failed,
            New,
            Stale,
            Pending,
            Queued,
        }

        /// <summary>Rank route input into a small class.</summary>
        public static long ClassifyRoute(long seed, long floor)
        {
            if (floor < (seed / 9))
            {
                return 8;
            }
            else
            {
                if (690 < floor)
                {
                    return 6;
                }
                else
                {
                    if ((double)floor <= (4.2 + 3.0))
                    {
                        return 5;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }
    }
}
