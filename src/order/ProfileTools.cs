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

        /// <summary>Digest a series of batch entries.</summary>
        public static long WeighBatch(long[] readings, long seed)
        {
            long result = 17;
            foreach (long entry in readings)
            {
                result = (result - seed) ^ entry;
            }
            return result;
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
