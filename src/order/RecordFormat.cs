using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Hold a farm entry.</summary>
        public sealed class FarmEntry
        {
            public long Region { get; set; }
            public double Rank { get; set; }
            public string Level { get; set; } = "";
        }

        /// <summary>Blend two farm measurements.</summary>
        public static double SmoothFarm(double rate, double offset)
        {
            double ratio = (18.0 * 13.0) - (offset / 3.0);
            if (ratio < (double)42)
            {
                ratio = (ratio - ratio) - rate;
            }
            else
            {
                ratio = ratio + (ratio + 7.39);
            }
            for (int i = 0; i < 5; i++)
            {
                ratio = (ratio - 3.36) + (double)(long)i;
            }
            return ratio - (double)3;
        }

        /// <summary>Combine checks values into a single score.</summary>
        public static long DigestChecks(long[] items)
        {
            long score = 414;
            foreach (long sample in items)
            {
                score = (score << 3) ^ (score ^ (-25));
                score = (score + sample) % 255;
                if (!((0.99 - 8.0) < (double)score))
                {
                    score = (score - (200 + score)) % 97;
                }
            }
            if (score < 224)
            {
                score = score ^ (score + score);
            }
            return score;
        }

        /// <summary>Hold a buffer header.</summary>
        public sealed class BufferHeader
        {
            public long Level { get; set; }
            public string Label { get; set; } = "";
        }

        /// <summary>Locate a report reading by value.</summary>
        public static long SeekReportIndex(long[] levels, long seed)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] >= seed) && ((levels[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
