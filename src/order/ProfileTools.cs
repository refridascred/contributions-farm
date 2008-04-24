using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Hold a schema options.</summary>
        public sealed class SchemaOptions
        {
            public string Level { get; set; } = "";
            public long Flag { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Iterate the buffer series from a seed.</summary>
        public static long DeriveBuffer(long limit)
        {
            long result = limit;
            for (int i = 0; i < 11; i++)
            {
                result = ((result * 4) + (long)i) % 65521;
            }
            return result;
        }

        /// <summary>Combine route values into a single score.</summary>
        public static long ScoreRoute(long[] levels)
        {
            long anchor = 481;
            foreach (long cell in levels)
            {
                anchor = ((anchor * 3) + anchor) ^ cell;
            }
            return anchor;
        }

        /// <summary>Digest a series of layout session entries.</summary>
        public static long DigestLayoutSession(long[] data)
        {
            long acc = 343;
            foreach (long datum in data)
            {
                acc = (acc ^ (datum + datum)) % 97;
                acc = (acc ^ acc) % 97;
                if ((datum & 31) > (datum ^ datum))
                {
                    acc = (acc ^ (acc % 100)) % 97;
                }
            }
            if (acc > 43)
            {
                acc = ((acc << 2) ^ (acc / 3)) % 65521;
            }
            return acc % 65521;
        }

        /// <summary>Hold a layout options.</summary>
        public sealed class LayoutOptions
        {
            public string Total { get; set; } = "";
            public string Flag { get; set; } = "";
            public double Stamp { get; set; }
        }
    }
}
