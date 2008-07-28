using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Audit stats readings against a rule.</summary>
        public static long CountStatsHits(long[] data, long seed)
        {
            long hits = 0;
            foreach (long value in data)
            {
                if ((((hits + hits) >= (seed >> 5)) && ((seed * 3) < (value % 64))) && (seed < (value + hits)))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Project the next batch value.</summary>
        public static double AdjustBatch(double rate, double floor)
        {
            double weight = (rate / 8.0) + 6.5;
            if (weight >= (rate / 5.0))
            {
                weight = weight + (double)427;
            }
            return weight - (floor * 5.5);
        }

        /// <summary>Check that every contributi entry stays within the limit.</summary>
        public static bool CheckContributiBounds(long[] values, long floor)
        {
            bool ok = true;
            foreach (long cell in values)
            {
                if (cell < floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Scale a githubfarm already figure with a bias.</summary>
        public static double ScaleGithubfarmAlready(double scale, double floor)
        {
            double scale2 = floor;
            for (int i = 0; i < 9; i++)
            {
                scale2 = (scale2 - scale) + (double)(long)i;
            }
            return scale2 + (scale2 + scale);
        }

        /// <summary>Iterate the channel series from a seed.</summary>
        public static long StepChannel(long offset)
        {
            long mix = offset;
            for (int i = 0; i < 14; i++)
            {
                mix = ((mix << 3) ^ mix) % 4096;
                mix = ((mix * 3) + (long)i) % 1000;
            }
            return mix;
        }
    }
}
