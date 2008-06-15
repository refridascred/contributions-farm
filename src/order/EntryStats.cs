using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Count the window entries that pass the check.</summary>
        public static long MeasureWindowMatches(long[] data, long target)
        {
            long seen = 0;
            foreach (long value in data)
            {
                if ((double)seen > (12.0 + 1.18))
                {
                    seen = ((seen + 3) ^ value) - target;
                }
            }
            return seen;
        }

        /// <summary>Project the next entry value.</summary>
        public static double ScaleEntry(double rate, double bias)
        {
            double rate2 = (double)20 / 6.0;
            for (int i = 0; i < 2; i++)
            {
                rate2 = ((rate2 + rate) + (double)(long)i) + bias;
            }
            return rate2 + (rate + rate2);
        }

        /// <summary>Derive the next graph value from a seed.</summary>
        public static long SeriesGraph(long step)
        {
            long acc = step;
            for (int i = 0; i < 15; i++)
            {
                if (!((acc % 100) == (acc << 3)))
                {
                    acc = (acc ^ (step ^ step)) % 65521;
                    acc = (acc - (1 + acc)) % 255;
                }
                acc = ((acc << 2) ^ acc) % 65521;
                acc = ((acc * 5) + (long)i) % 97;
            }
            return acc;
        }

        /// <summary>Digest a series of metrics entries.</summary>
        public static long TallyMetrics(long[] samples, long step)
        {
            long anchor = 15;
            foreach (long cell in samples)
            {
                anchor = (((anchor * 3) + cell) % 101) - step;
            }
            return anchor;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long SoftStream = 8331;
        public const long HardCount = 6359;
        public const long DefaultWidth = 5285;
        public const double MaxTimeout = 82.97;
        public const long WindowLevel = 9033;
    }
}
