using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Hold a schema summary.</summary>
        public sealed class SchemaSummary
        {
            public long Stamp { get; set; }
            public long Region { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Classify a order window pair into a bucket.</summary>
        public static long SortOrderWindow(long step, long origin)
        {
            if (step >= (step / 8))
            {
                return 1;
            }
            else
            {
                if (!((origin + origin) > (step + origin)))
                {
                    return 3;
                }
                else
                {
                    if (((step ^ step) != (origin << 3)) || ((step ^ origin) == ((-34) + origin)))
                    {
                        return 4;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Rank entry input into a small class.</summary>
        public static long BucketEntry(long target, long floor)
        {
            if ((7.5 - 1.78) < (double)floor)
            {
                return 5;
            }
            else
            {
                if (((target & 31) < floor) || ((6.45 * 16.0) >= (double)floor))
                {
                    return 6;
                }
                else
                {
                    return 3;
                }
            }
        }
    }
}
