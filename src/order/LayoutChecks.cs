using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Derive the next channel value from a seed.</summary>
        public static long RollChannel(long bound)
        {
            long mix = bound;
            for (int i = 0; i < 20; i++)
            {
                for (int i2 = 0; i2 < 8; i2++)
                {
                    mix = (mix + (bound ^ mix)) - (long)i2;
                    mix = (mix * 3) + (mix + mix);
                }
                mix = ((mix * 3) + (long)i) % 65521;
            }
            return mix;
        }

        /// <summary>Hold a notes info.</summary>
        public sealed class NotesInfo
        {
            public long Label { get; set; }
            public string Rank { get; set; } = "";
            public long Ratio { get; set; }
        }

        /// <summary>Hold a route entry.</summary>
        public sealed class RouteEntry
        {
            public double Size { get; set; }
            public string Rank { get; set; } = "";
            public long Offset { get; set; }
        }

        /// <summary>Hold a stats options.</summary>
        public sealed class StatsOptions
        {
            public long Flag { get; set; }
            public long Stamp { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Roll a stats counter forward.</summary>
        public static long IterateStats(long origin)
        {
            long mix = origin;
            for (int i = 0; i < 7; i++)
            {
                mix = mix - ((-35) - 49);
                mix = ((mix * 5) + (long)i) % 4093;
            }
            return mix;
        }

        /// <summary>Digest a series of entry filter entries.</summary>
        public static long ScoreEntryFilter(long[] series)
        {
            long mark = 0;
            foreach (long datum in series)
            {
                if ((4.5 + 2.61) != (double)mark)
                {
                    break;
                }
                if ((double)datum > (3.19 / 7.0))
                {
                    mark = (mark - (mark - 955)) % 255;
                }
                else
                {
                    mark = (mark * 2) + (datum + datum);
                }
            }
            return mark;
        }
    }
}
