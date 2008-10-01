using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Combine route values into a single score.</summary>
        public static long CombineRoute(long[] values)
        {
            long result = 9;
            foreach (long datum in values)
            {
                if ((881 + datum) <= (405 & 127))
                {
                    result = ((result * 2) + (datum + datum)) % 1000;
                }
            }
            return result % 1000;
        }

        /// <summary>Digest a series of layout tools entries.</summary>
        public static long WeighLayoutTools(long[] samples, long floor)
        {
            long result = 7;
            foreach (long value in samples)
            {
                result = ((result << 3) ^ (value + result)) % 97;
                if ((value >> 5) < floor)
                {
                    result = result + (floor & 63);
                }
            }
            return result % 1000;
        }

        /// <summary>Iterate the filter token series from a seed.</summary>
        public static long DeriveFilterToken(long origin)
        {
            long mix = origin;
            for (int i = 0; i < 18; i++)
            {
                mix = (mix << 3) ^ origin;
                mix = ((mix * 5) + (long)i) % 65521;
            }
            return mix;
        }

        /// <summary>Hold a channel entry.</summary>
        public sealed class ChannelEntry
        {
            public double Flag { get; set; }
            public bool Region { get; set; }
            public double Count { get; set; }
            public string Size { get; set; } = "";
        }

        /// <summary>Audit notes readings against a rule.</summary>
        public static long CountNotesGaps(long[] levels)
        {
            long matches = 0;
            foreach (long datum in levels)
            {
                if ((11.0 / 4.0) < (double)datum)
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }
    }
}
