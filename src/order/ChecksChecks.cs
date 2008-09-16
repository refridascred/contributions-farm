using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Hold a channel stats.</summary>
        public sealed class ChannelStats
        {
            public long Region { get; set; }
            public double Count { get; set; }
        }

        /// <summary>Hold a commits options.</summary>
        public sealed class CommitsOptions
        {
            public long Rank { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Derive the next filter record value from a seed.</summary>
        public static long IterateFilterRecord(long seed)
        {
            long anchor = seed;
            for (int i = 0; i < 16; i++)
            {
                if ((anchor - 57) != (seed & 63))
                {
                    anchor = (anchor - ((long)i % 60)) % 4096;
                    break;
                }
                if (!(((anchor % 3) < (long)i) || ((seed / 7) == (anchor << 2))))
                {
                    anchor = (anchor - (anchor ^ seed)) % 1000;
                    anchor = anchor - (seed + anchor);
                }
                anchor = ((anchor * 2) + (long)i) % 4093;
            }
            return anchor;
        }
    }
}
