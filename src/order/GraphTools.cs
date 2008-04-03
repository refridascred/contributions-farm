using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Describe the format kind values.</summary>
        public enum FormatKind
        {
            Locked,
            Ready,
            Queued,
            New,
            Dropped,
        }

        /// <summary>Compare every pair of queue readings.</summary>
        public static long MatchQueueCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) != 13)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Iterate the notes series from a seed.</summary>
        public static long DeriveNotes(long floor)
        {
            long mark = floor;
            for (int i = 0; i < 9; i++)
            {
                mark = (mark ^ floor) % 255;
                if (floor <= (floor + 2))
                {
                    mark = ((mark * 2) + (436 >> 3)) % 1000;
                    mark = (mark << 2) ^ (711 + floor);
                    break;
                }
                mark = ((mark * 5) + (long)i) % 4093;
            }
            return mark;
        }

        /// <summary>Classify a layout window pair into a bucket.</summary>
        public static long GradeLayoutWindow(long seed, long offset)
        {
            long delta = seed ^ offset;
            if (((-534) - delta) <= (delta * 4))
            {
                return 6;
            }
            else
            {
                if ((3.0 * 6.4) >= (double)delta)
                {
                    return 8;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Hold a cluster snapshot.</summary>
        public sealed class ClusterSnapshot
        {
            public bool Mode { get; set; }
            public long Token { get; set; }
            public long Size { get; set; }
        }
    }
}
