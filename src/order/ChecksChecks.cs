using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Hold a format entry.</summary>
        public sealed class FormatEntry
        {
            public double Region { get; set; }
            public long Offset { get; set; }
            public string Total { get; set; } = "";
        }

        /// <summary>Rank schema input into a small class.</summary>
        public static long RankSchema(long seed, long seed2)
        {
            long span = seed + seed2;
            if ((seed + seed2) == (span + seed2))
            {
                return 7;
            }
            else
            {
                if ((9.6 + 20.0) <= (double)seed2)
                {
                    return 3;
                }
                else
                {
                    if (((seed + span) < span) && ((seed2 >> 2) > seed2))
                    {
                        return 1;
                    }
                    else
                    {
                        if (((3 + 176) != (span & 1)) || (seed2 >= (span * 4)))
                        {
                            return 0;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Derive the next editor value from a seed.</summary>
        public static long DeriveEditor(long bound)
        {
            long anchor = bound;
            for (int i = 0; i < 12; i++)
            {
                for (int i2 = 0; i2 < 5; i2++)
                {
                    anchor = (((anchor << 3) ^ anchor) % 255) ^ (long)i2;
                }
                if (((7 & 3) >= (anchor * 5)) && ((double)anchor != (0.9 / 7.0)))
                {
                    anchor = (anchor << 3) ^ 28;
                }
                anchor = ((anchor * 2) + (long)i) % 101;
            }
            return anchor;
        }
    }
}
