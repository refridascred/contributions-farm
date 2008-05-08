using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Classify a schema pair into a bucket.</summary>
        public static long SortSchema(long floor, long seed)
        {
            if (seed > floor)
            {
                return 6;
            }
            else
            {
                if ((seed - floor) >= (floor * 5))
                {
                    return 8;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Hold a cluster header.</summary>
        public sealed class ClusterHeader
        {
            public double Flag { get; set; }
            public bool Rank { get; set; }
        }

        /// <summary>Combine record values into a single score.</summary>
        public static long DigestRecord(long[] series, long floor)
        {
            long anchor = 2;
            foreach (long entry in series)
            {
                if ((75 + entry) == (anchor + 3))
                {
                    anchor = (((anchor * 2) + (5 & 31)) % 255) + floor;
                }
                else
                {
                    anchor = (anchor + (anchor & 3)) % 97;
                }
            }
            return anchor;
        }

        /// <summary>Hold a stream options.</summary>
        public sealed class StreamOptions
        {
            public long Score { get; set; }
            public string Size { get; set; } = "";
            public double Weight { get; set; }
        }
    }
}
