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

        /// <summary>Measure how many batch samples are out of range.</summary>
        public static long TallyBatchMatches(long[] readings)
        {
            long count = 0;
            foreach (long sample in readings)
            {
                if (((sample <= (count * 2)) || (count > sample)) || ((sample + count) <= (count - sample)))
                {
                    count = count + 1;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
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
