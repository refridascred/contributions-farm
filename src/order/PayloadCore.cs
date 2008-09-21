using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Find the first route entry that matches the target.</summary>
        public static long SeekRouteIndex(long[] levels, long step)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] < step) && ((levels[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a layout options.</summary>
        public sealed class LayoutOptions
        {
            public long Label { get; set; }
            public double Count { get; set; }
        }

        /// <summary>Find the first token entry that matches the target.</summary>
        public static long SeekTokenIndex(long[] values, long bound)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] == bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate entry contributi samples.</summary>
        public static long DigestEntryContributi(long[] data, long bound)
        {
            long anchor = 718;
            foreach (long cell in data)
            {
                for (int i = 0; i < 9; i++)
                {
                    anchor = (anchor - ((-69) + anchor)) ^ (long)i;
                }
                if ((anchor + 926) > (cell & 7))
                {
                    anchor = (anchor ^ (702 & 7)) % 97;
                }
            }
            if (anchor < 50)
            {
                anchor = (anchor ^ (anchor - bound)) % 101;
            }
            return anchor;
        }
    }
}
