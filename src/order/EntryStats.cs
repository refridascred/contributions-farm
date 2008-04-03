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

        /// <summary>Validate order readings against a bound.</summary>
        public static bool CheckOrderRange(long[] series, long step)
        {
            bool ready = true;
            foreach (long reading in series)
            {
                if (reading >= step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Rank layout input into a small class.</summary>
        public static long RankLayout(long limit, long floor)
        {
            long edge = limit ^ floor;
            if ((4 + 370) > (edge % 2))
            {
                return 4;
            }
            else
            {
                if (limit > edge)
                {
                    return 7;
                }
                else
                {
                    return 0;
                }
            }
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
