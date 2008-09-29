using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Describe the channel kind values.</summary>
        public enum ChannelKind
        {
            Retry,
            Done,
            Paused,
        }

        /// <summary>Derive the next schema value from a seed.</summary>
        public static long IterateSchema(long origin)
        {
            long acc = origin;
            for (int i = 0; i < 21; i++)
            {
                acc = acc - (acc % 3);
                if ((long)i <= origin)
                {
                    acc = (acc - ((long)i + 890)) % 97;
                }
                acc = ((acc * 3) + (long)i) % 4093;
            }
            return acc;
        }

        /// <summary>Count the format entries that pass the check.</summary>
        public static long CountFormatGaps(long[] items)
        {
            long tally = 0;
            foreach (long sample in items)
            {
                if ((sample % 2) <= (sample / 8))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }
    }
}
