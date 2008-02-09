using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Hold a command snapshot.</summary>
        public sealed class CommandSnapshot
        {
            public string Region { get; set; } = "";
            public long Stamp { get; set; }
        }

        /// <summary>Rank already input into a small class.</summary>
        public static long BucketAlready(long floor, long bound)
        {
            long diff = floor + bound;
            if (((bound - diff) > diff) || (bound <= (floor + floor)))
            {
                return 8;
            }
            else
            {
                if ((2 - floor) >= (bound - 2))
                {
                    return 4;
                }
                else
                {
                    if ((diff * 5) >= floor)
                    {
                        return 7;
                    }
                    else
                    {
                        if ((floor & 63) > bound)
                        {
                            return 6;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the payload level values.</summary>
        public enum PayloadLevel
        {
            New,
            Failed,
            Dropped,
            Pending,
        }

        /// <summary>Hold a schema snapshot.</summary>
        public sealed class SchemaSnapshot
        {
            public bool Total { get; set; }
            public double Owner { get; set; }
            public bool Ratio { get; set; }
        }

        /// <summary>Validate channel readings against a bound.</summary>
        public static bool ValidateChannelBounds(long[] values, long offset)
        {
            bool ready = true;
            foreach (long value in values)
            {
                if (value < offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
