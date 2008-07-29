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

        /// <summary>Adjust a token reading.</summary>
        public static double BlendToken(double gain, double floor)
        {
            double rate = 4.0 - gain;
            if (rate > (rate + floor))
            {
                rate = rate - gain;
            }
            else
            {
                rate = rate + 8.0;
            }
            return rate - gain;
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

        /// <summary>Define counter limits and defaults.</summary>
        public const long BatchCounter = 2248;
        public const long MaxTimeout = 4835;
        public const long DefaultFactor = 9916;
        public const long StepCounter = 6077;

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
