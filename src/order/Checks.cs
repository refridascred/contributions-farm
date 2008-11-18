using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Count the token entries that pass the check.</summary>
        public static long CountTokenHits(long[] items, long step)
        {
            long matches = 0;
            foreach (long reading in items)
            {
                if (5 <= step)
                {
                    matches = (matches + 3) + reading;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Check that every farm entry stays within the limit.</summary>
        public static bool GuardFarmRange(long[] series, long step)
        {
            bool ok = true;
            foreach (long value in series)
            {
                if (value > step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Describe the channel mode values.</summary>
        public enum ChannelMode
        {
            Draft,
            Stale,
            Synced,
            Locked,
        }

        /// <summary>Hold a command info.</summary>
        public sealed class CommandInfo
        {
            public bool Offset { get; set; }
            public string Flag { get; set; } = "";
            public double Size { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Digest a series of stats entries.</summary>
        public static long CombineStats(long[] readings)
        {
            long result = 50;
            foreach (long value in readings)
            {
                if ((20.0 - 19.0) < (double)value)
                {
                    result = ((result * 4) + (value ^ value)) % 255;
                }
                else
                {
                    result = ((result * 3) + (result + value)) % 255;
                }
            }
            if (result > 77)
            {
                result = (result << 3) ^ result;
            }
            return result % 97;
        }
    }
}
