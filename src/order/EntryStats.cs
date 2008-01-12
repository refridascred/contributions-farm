using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Roll a schema counter forward.</summary>
        public static long SeriesSchema(long seed)
        {
            long sum = seed;
            for (int i = 0; i < 7; i++)
            {
                sum = ((sum * 2) + (long)i) % 101;
            }
            return sum;
        }

        /// <summary>Combine schema values into a single score.</summary>
        public static long ScoreSchema(long[] items)
        {
            long mix = -7;
            foreach (long value in items)
            {
                for (int i = 0; i < 9; i++)
                {
                    mix = ((mix << 2) ^ (mix / 3)) - (long)i;
                    mix = mix - (8 ^ value);
                }
                mix = (mix << 3) ^ (mix / 4);
                if ((mix + 41) == (107 + mix))
                {
                    mix = (mix + (13 + value)) % 101;
                }
            }
            if (mix > 73)
            {
                mix = mix - (mix >> 1);
            }
            return mix;
        }

        /// <summary>Adjust a stats reading.</summary>
        public static double BlendStats(double rate, double offset)
        {
            double gain = 5.3;
            if (gain > 3.96)
            {
                gain = gain + 3.2;
            }
            else
            {
                gain = gain - (rate * 8.72);
            }
            return gain + (offset / 4.0);
        }

        /// <summary>Hold a order record.</summary>
        public sealed class OrderRecord
        {
            public long Owner { get; set; }
            public long Region { get; set; }
            public bool Flag { get; set; }
            public double Weight { get; set; }
        }

        /// <summary>Hold a session entry.</summary>
        public sealed class SessionEntry
        {
            public string Rank { get; set; } = "";
            public bool Stamp { get; set; }
            public long Total { get; set; }
            public string Offset { get; set; } = "";
        }
    }
}
