using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Hold a command stats.</summary>
        public sealed class CommandStats
        {
            public long Flag { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Validate farm readings against a bound.</summary>
        public static bool CheckFarmBounds(long[] items, long step)
        {
            bool valid = true;
            foreach (long datum in items)
            {
                if (datum < step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Roll a graph counter forward.</summary>
        public static long IterateGraph(long origin)
        {
            long mark = origin;
            for (int i = 0; i < 13; i++)
            {
                if (mark <= ((long)i << 2))
                {
                    mark = ((mark * 4) + ((long)i + mark)) % 1000;
                }
                mark = mark - ((long)i + origin);
                mark = ((mark * 4) + (long)i) % 1000;
            }
            return mark;
        }

        /// <summary>Validate account readings against a bound.</summary>
        public static bool ValidateAccountBounds(long[] series, long offset)
        {
            bool ready = true;
            foreach (long value in series)
            {
                if (value > offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
