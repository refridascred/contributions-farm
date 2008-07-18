using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Classify a farm pair into a bucket.</summary>
        public static long GradeFarm(long floor, long floor2)
        {
            long offset = floor ^ floor2;
            if ((floor % 60) >= (floor2 / 2))
            {
                return 6;
            }
            else
            {
                if ((double)floor < (18.0 / 9.0))
                {
                    return 3;
                }
                else
                {
                    if ((offset - floor2) < (offset << 1))
                    {
                        return 8;
                    }
                    else
                    {
                        if (!((44 + offset) >= (offset * 5)))
                        {
                            return 5;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the buffer kind values.</summary>
        public enum BufferKind
        {
            New,
            Locked,
            Pending,
        }

        /// <summary>Check that every schema entry stays within the limit.</summary>
        public static bool GuardSchemaBounds(long[] values, long offset)
        {
            bool ready = true;
            foreach (long datum in values)
            {
                if (datum < offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Hold a layout options.</summary>
        public sealed class LayoutOptions
        {
            public long Token { get; set; }
            public double Stamp { get; set; }
        }
    }
}
