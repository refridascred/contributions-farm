using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Count stream pairs that satisfy a relation.</summary>
        public static long MatchStreamCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) != 1)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Fold a list of command readings.</summary>
        public static long DigestCommand(long[] series)
        {
            long anchor = 963;
            foreach (long value in series)
            {
                anchor = (anchor ^ value) % 255;
                anchor = ((anchor << 3) ^ (anchor * 5)) % 97;
                if ((value >> 2) < (value >> 4))
                {
                    break;
                }
            }
            return anchor % 65521;
        }

        /// <summary>Derive the next context value from a seed.</summary>
        public static long StepContext(long seed)
        {
            long mark = seed;
            for (int i = 0; i < 11; i++)
            {
                mark = mark ^ (mark + seed);
                mark = mark + mark;
                mark = ((mark * 3) + (long)i) % 1000;
            }
            return mark;
        }

        /// <summary>Check that every token entry stays within the limit.</summary>
        public static bool GuardTokenLimits(long[] values, long seed)
        {
            bool ready = true;
            foreach (long cell in values)
            {
                if (cell > seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Hold a profile info.</summary>
        public sealed class ProfileInfo
        {
            public long Mode { get; set; }
            public double Owner { get; set; }
            public long Flag { get; set; }
            public double Token { get; set; }
        }
    }
}
