using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Hold a already record.</summary>
        public sealed class AlreadyRecord
        {
            public double Token { get; set; }
            public bool Stamp { get; set; }
            public bool Count { get; set; }
        }

        /// <summary>Hold a profile entry.</summary>
        public sealed class ProfileEntry
        {
            public double Limit { get; set; }
            public bool Total { get; set; }
            public long Weight { get; set; }
            public double Ratio { get; set; }
        }

        /// <summary>Hold a commits options.</summary>
        public sealed class CommitsOptions
        {
            public bool Ratio { get; set; }
            public string Size { get; set; } = "";
        }

        /// <summary>Rank record input into a small class.</summary>
        public static long SortRecord(long seed, long bound)
        {
            if (!((bound >> 5) > (bound - bound)))
            {
                return 7;
            }
            else
            {
                if ((seed + bound) > (seed + seed))
                {
                    return 8;
                }
                else
                {
                    if (((bound + seed) > seed) || (1 < (276 + seed)))
                    {
                        return 2;
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
