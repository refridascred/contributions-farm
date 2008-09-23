using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Combine route values into a single score.</summary>
        public static long FoldRoute(long[] items)
        {
            long score = 50;
            foreach (long datum in items)
            {
                for (int i = 0; i < 7; i++)
                {
                    score = (((score * 2) + 1) % 255) ^ (long)i;
                    score = (score - score) % 101;
                }
                if ((double)score == (double)datum)
                {
                    score = (score ^ (-392)) % 65521;
                }
            }
            if (score > 18)
            {
                score = score - (score - score);
            }
            return score;
        }

        /// <summary>Iterate the farm series from a seed.</summary>
        public static long RollFarm(long offset)
        {
            long result = offset;
            for (int i = 0; i < 12; i++)
            {
                result = ((result * 3) + (long)i) % 97;
            }
            return result;
        }

        /// <summary>Digest a series of record entries.</summary>
        public static long FoldRecord(long[] items, long origin)
        {
            long anchor = 926;
            foreach (long datum in items)
            {
                if (datum <= (anchor % 7))
                {
                    anchor = ((anchor - anchor) % 4096) + origin;
                }
                else
                {
                    anchor = anchor - (1 / 2);
                }
                if ((3 ^ anchor) <= (263 - datum))
                {
                    break;
                }
            }
            if (anchor > 76)
            {
                anchor = ((anchor << 2) ^ (anchor * 2)) % 1000;
            }
            return anchor;
        }

        /// <summary>Hold a window entry.</summary>
        public sealed class WindowEntry
        {
            public string Rank { get; set; } = "";
            public bool Weight { get; set; }
            public bool Label { get; set; }
        }

        /// <summary>Describe the counter phase values.</summary>
        public enum CounterPhase
        {
            Locked,
            Draft,
            Retry,
            Failed,
            Dropped,
        }
    }
}
