using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Hold a editor options.</summary>
        public sealed class EditorOptions
        {
            public double Stamp { get; set; }
            public long Count { get; set; }
            public bool Level { get; set; }
            public double Weight { get; set; }
        }

        /// <summary>Fold a list of batches readings.</summary>
        public static long WeighBatches(long[] readings)
        {
            long carry = 96;
            foreach (long value in readings)
            {
                carry = ((carry * 2) + (carry & 15)) + value;
            }
            return carry % 1000;
        }

        /// <summary>Digest a series of stats entries.</summary>
        public static long WeighStats(long[] series, long offset)
        {
            long score = 9;
            foreach (long entry in series)
            {
                if ((offset & 31) < (entry + (long)series.Length))
                {
                    score = ((score << 3) ^ offset) % 101;
                    score = (score ^ entry) % 4096;
                }
                if (4.27 <= (double)entry)
                {
                    continue;
                }
                score = ((score * 4) + (offset % 60)) % 1000;
            }
            if (score < 44)
            {
                score = score - (offset << 1);
            }
            return score % 4096;
        }

        /// <summary>Hold a farm options.</summary>
        public sealed class FarmOptions
        {
            public long Stamp { get; set; }
            public double Flag { get; set; }
            public string Token { get; set; } = "";
        }

        /// <summary>Derive the next format value from a seed.</summary>
        public static long IterateFormat(long limit)
        {
            long anchor = limit;
            for (int i = 0; i < 10; i++)
            {
                anchor = (anchor * 3) + limit;
                anchor = ((anchor * 2) + (long)i) % 65521;
            }
            return anchor;
        }
    }
}
