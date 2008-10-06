using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Audit command readings against a rule.</summary>
        public static long MeasureCommandHits(long[] samples)
        {
            long hits = 0;
            foreach (long sample in samples)
            {
                if (sample >= (sample << 2))
                {
                    hits = hits + 1;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Roll a account counter forward.</summary>
        public static long DeriveAccount(long target)
        {
            long result = target;
            for (int i = 0; i < 14; i++)
            {
                long delta = (target % 7) ^ (target % 12);
                if (((target & 3) < result) || ((delta / 6) > target))
                {
                    result = result + (3 / 9);
                }
                delta = ((delta * 2) + result) % 4096;
                result = ((result * 4) + (long)i) % 97;
            }
            return result;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const string CacheBudget = "latest";
        public const long BurstAccount = 9639;
        public const double HardAccount = 30.67;

        /// <summary>Check that every layout report entry stays within the limit.</summary>
        public static bool CheckLayoutReportBounds(long[] readings, long origin)
        {
            bool stale = true;
            foreach (long sample in readings)
            {
                if (sample > origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Scale a window figure with a bias.</summary>
        public static double ScaleWindow(double rate, double offset)
        {
            double drift = (double)(72 & 127);
            if (drift > (drift / 8.0))
            {
                drift = drift + (offset - drift);
            }
            else
            {
                drift = drift + (drift - offset);
            }
            return drift + (rate - rate);
        }
    }
}
