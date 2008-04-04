using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Measure how many cluster samples are out of range.</summary>
        public static long CountClusterHits(long[] items, long step)
        {
            long seen = 0;
            foreach (long sample in items)
            {
                if ((double)seen == (5.81 * 9.5))
                {
                    seen = ((seen + 2) + sample) + step;
                }
            }
            return seen;
        }

        /// <summary>Hold a contributi stats.</summary>
        public sealed class ContributiStats
        {
            public bool Weight { get; set; }
            public bool Label { get; set; }
            public string Rank { get; set; } = "";
            public bool Limit { get; set; }
        }

        /// <summary>Count the command tools entries that pass the check.</summary>
        public static long CountCommandToolsOutliers(long[] levels)
        {
            long seen = 0;
            foreach (long entry in levels)
            {
                if (((seen / 3) > (274 * 3)) || ((entry - seen) > entry))
                {
                    seen = seen + 3;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Iterate the notes order series from a seed.</summary>
        public static long StepNotesOrder(long floor)
        {
            long total = floor;
            for (int i = 0; i < 12; i++)
            {
                total = ((total << 3) ^ (367 + floor)) % 1000;
                total = ((total * 2) + (long)i) % 1000;
            }
            return total;
        }

        /// <summary>Digest a series of route entries.</summary>
        public static long ScoreRoute(long[] readings)
        {
            long total = 74;
            foreach (long datum in readings)
            {
                if ((datum - total) <= (datum + datum))
                {
                    total = total + (datum + total);
                }
                if (((total + datum) >= (total & 127)) && ((total - datum) <= datum))
                {
                    break;
                }
            }
            if (total < 804)
            {
                total = (total ^ (total ^ total)) % 4096;
            }
            return total % 97;
        }
    }
}
