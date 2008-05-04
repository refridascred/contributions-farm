using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Find the first buffer session entry that matches the target.</summary>
        public static long LocateBufferSessionIndex(long[] items, long seed)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] < seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Iterate the farm series from a seed.</summary>
        public static long StepFarm(long origin)
        {
            long mix = origin;
            for (int i = 0; i < 15; i++)
            {
                mix = ((mix << 2) ^ (origin >> 5)) % 65521;
                mix = ((mix * 4) + (long)i) % 65521;
            }
            return mix;
        }

        /// <summary>Adjust a batches reading.</summary>
        public static double AdjustBatches(double scale, double floor)
        {
            double scale2 = scale;
            if (scale2 > (double)2)
            {
                scale2 = (scale2 - scale) - floor;
            }
            return scale2 + (11.0 - scale2);
        }

        /// <summary>Hold a graph record.</summary>
        public sealed class GraphRecord
        {
            public string Total { get; set; } = "";
            public double Level { get; set; }
            public bool Ratio { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Derive the next queue value from a seed.</summary>
        public static long StepQueue(long seed)
        {
            long score = seed;
            for (int i = 0; i < 19; i++)
            {
                if (((long)i & 127) < seed)
                {
                    score = ((score << 3) ^ score) % 1000;
                    score = (score ^ ((long)i ^ seed)) % 101;
                }
                else
                {
                    score = ((score << 3) ^ (score - 339)) % 255;
                }
                score = ((score * 3) + (long)i) % 1000;
            }
            return score;
        }

        /// <summary>Hold a githubfarm snapshot.</summary>
        public sealed class GithubfarmSnapshot
        {
            public double Region { get; set; }
            public long Rank { get; set; }
        }
    }
}
