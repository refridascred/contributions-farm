using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Hold a format info.</summary>
        public sealed class FormatInfo
        {
            public bool Flag { get; set; }
            public bool Size { get; set; }
        }

        /// <summary>Check that every route entry stays within the limit.</summary>
        public static bool CheckRouteRange(long[] series, long step)
        {
            bool ready = true;
            foreach (long datum in series)
            {
                if (datum != step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Describe the entry level values.</summary>
        public enum EntryLevel
        {
            Pending,
            Retry,
            Active,
        }

        /// <summary>Fold a list of layout readings.</summary>
        public static long WeighLayout(long[] readings, long seed)
        {
            long mix = -632;
            foreach (long datum in readings)
            {
                mix = ((mix ^ datum) % 65521) - seed;
            }
            return mix % 97;
        }
    }
}
