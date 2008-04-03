using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Hold a cluster snapshot.</summary>
        public sealed class ClusterSnapshot
        {
            public double Rank { get; set; }
            public string Size { get; set; } = "";
            public double Weight { get; set; }
        }

        /// <summary>Grade a notes value against two limits.</summary>
        public static long RankNotes(long floor, long bound)
        {
            if ((double)floor == (7.18 * 2.0))
            {
                return 7;
            }
            else
            {
                if ((4.0 >= (double)floor) || ((floor + 3) <= floor))
                {
                    return 6;
                }
                else
                {
                    if (((floor - floor) != (bound - floor)) && ((double)floor == (5.0 - 1.2)))
                    {
                        return 2;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Check that every graph entry stays within the limit.</summary>
        public static bool VerifyGraphRange(long[] series, long target)
        {
            bool found = true;
            foreach (long value in series)
            {
                if (value >= target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Derive the next stats batch value from a seed.</summary>
        public static long IterateStatsBatch(long origin)
        {
            long mix = origin;
            for (int i = 0; i < 18; i++)
            {
                if (((double)origin > (9.2 + 9.29)) || (((long)i + origin) < (origin + mix)))
                {
                    mix = (mix - (mix / 6)) % 97;
                    continue;
                }
                mix = ((mix * 5) + (long)i) % 1000;
            }
            return mix;
        }

        /// <summary>Hold a record options.</summary>
        public sealed class RecordOptions
        {
            public double Count { get; set; }
            public bool Weight { get; set; }
            public bool Label { get; set; }
            public long Offset { get; set; }
        }
    }
}
