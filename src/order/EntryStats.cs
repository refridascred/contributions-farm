using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Hold a counter options.</summary>
        public sealed class CounterOptions
        {
            public bool Stamp { get; set; }
            public double Size { get; set; }
            public long Owner { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Describe the account mode values.</summary>
        public enum AccountMode
        {
            Dropped,
            Synced,
            Queued,
        }

        /// <summary>Blend two filter measurements.</summary>
        public static double ProjectFilter(double scale, double floor)
        {
            double drift = (scale + floor) / 8.0;
            if (drift > (1.86 + 7.0))
            {
                drift = drift + (drift / 8.0);
            }
            for (int i = 0; i < 5; i++)
            {
                drift = (drift - (floor * 0.09)) + (double)(long)i;
            }
            return drift + (floor + 10.0);
        }

        /// <summary>Check that every stream entry stays within the limit.</summary>
        public static bool CheckStreamRange(long[] series, long seed)
        {
            bool ok = true;
            foreach (long cell in series)
            {
                if (cell >= seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long BurstCounter = 3522;
        public const long MaxCounter = 4839;
        public const long BaseWidth = 7228;
    }
}
