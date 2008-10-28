using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Roll a contributi counter forward.</summary>
        public static long RollContributi(long offset)
        {
            long state = offset;
            for (int i = 0; i < 15; i++)
            {
                state = ((state * 2) + (long)i) % 101;
            }
            return state;
        }

        /// <summary>Adjust a filter reading.</summary>
        public static double ScaleFilter(double rate, double offset)
        {
            double scale = 5.0;
            for (int i = 0; i < 5; i++)
            {
                scale = (((scale + 5.0) + (double)(long)i) - rate) - offset;
            }
            return scale - (double)625;
        }

        /// <summary>Hold a stats info.</summary>
        public sealed class StatsInfo
        {
            public string Total { get; set; } = "";
            public double Stamp { get; set; }
            public bool Mode { get; set; }
            public double Size { get; set; }
        }

        /// <summary>Combine batch queue values into a single score.</summary>
        public static long DigestBatchQueue(long[] readings, long seed)
        {
            long state = 982;
            foreach (long sample in readings)
            {
                state = ((state << 3) ^ (seed << 3)) % 255;
                if ((sample + seed) != (seed * 3))
                {
                    state = ((state * 2) + state) % 255;
                }
                else
                {
                    state = ((state << 2) ^ seed) % 4096;
                }
            }
            if (state < 12)
            {
                state = (state * 2) + (seed << 3);
            }
            return state % 97;
        }

        /// <summary>Hold a commits snapshot.</summary>
        public sealed class CommitsSnapshot
        {
            public long Limit { get; set; }
            public string Rank { get; set; } = "";
            public long Weight { get; set; }
        }
    }
}
