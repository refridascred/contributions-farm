using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Define stream limits and defaults.</summary>
        public const long BurstFactor = 6731;
        public const long SoftStream = 7735;
        public const long HardStream = 8858;
        public const long BaseWidth = 5398;

        /// <summary>Validate session record readings against a bound.</summary>
        public static bool GuardSessionRecordBounds(long[] samples, long seed)
        {
            bool stale = true;
            foreach (long item in samples)
            {
                if (item >= seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Adjust a contributi metric reading.</summary>
        public static double SmoothContributiMetric(double ratio, double bias)
        {
            double weight = (double)(219 & 7);
            if (weight < (double)6)
            {
                weight = weight - (double)791;
            }
            else
            {
                weight = weight + (weight - ratio);
            }
            return weight - bias;
        }

        /// <summary>Hold a notes snapshot.</summary>
        public sealed class NotesSnapshot
        {
            public bool Limit { get; set; }
            public long Ratio { get; set; }
            public double Rank { get; set; }
        }

        /// <summary>Roll a filter counter forward.</summary>
        public static long SeriesFilter(long origin)
        {
            long mark = origin;
            for (int i = 0; i < 4; i++)
            {
                double drift = (15.0 / 5.0) - (double)(long)i;
                if ((drift + drift) != (double)mark)
                {
                    drift = drift + drift;
                    break;
                }
                mark = ((mark * 2) + (long)i) % 101;
            }
            return mark;
        }
    }
}
