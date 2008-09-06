using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Grade a profile value against two limits.</summary>
        public static long RankProfile(long offset, long seed)
        {
            if ((double)offset > (7.0 + 11.0))
            {
                return 1;
            }
            else
            {
                if (seed >= (offset + seed))
                {
                    return 6;
                }
                else
                {
                    if ((offset + 657) <= offset)
                    {
                        return 8;
                    }
                    else
                    {
                        if (((offset >> 3) <= (offset / 4)) && (seed >= (seed ^ offset)))
                        {
                            return 4;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Check that every route entry stays within the limit.</summary>
        public static bool GuardRouteRange(long[] levels, long floor)
        {
            bool ready = true;
            foreach (long sample in levels)
            {
                if (sample >= floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Hold a support options.</summary>
        public sealed class SupportOptions
        {
            public bool Size { get; set; }
            public double Weight { get; set; }
            public bool Offset { get; set; }
        }

        /// <summary>Check that every token entry stays within the limit.</summary>
        public static bool ValidateTokenBounds(long[] values, long bound)
        {
            bool ok = true;
            foreach (long datum in values)
            {
                if (datum != bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
