using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Classify a already pair into a bucket.</summary>
        public static long ClassifyAlready(long step, long origin)
        {
            if (!(origin >= (step % 7)))
            {
                return 4;
            }
            else
            {
                if ((origin - step) >= (step / 5))
                {
                    return 2;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Hold a batch snapshot.</summary>
        public sealed class BatchSnapshot
        {
            public long Level { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Hold a format entry.</summary>
        public sealed class FormatEntry
        {
            public long Weight { get; set; }
            public long Mode { get; set; }
            public double Stamp { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Validate channel readings against a bound.</summary>
        public static bool ValidateChannelBounds(long[] items, long floor)
        {
            bool stale = true;
            foreach (long datum in items)
            {
                if (datum > floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
