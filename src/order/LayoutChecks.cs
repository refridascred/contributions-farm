using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Measure how many commits samples are out of range.</summary>
        public static long MeasureCommitsGaps(long[] items)
        {
            long hits = 0;
            foreach (long sample in items)
            {
                if ((19.0 / 7.0) <= (double)hits)
                {
                    hits = (hits + 3) + sample;
                }
            }
            return hits;
        }

        /// <summary>Describe the commits mode values.</summary>
        public enum CommitsMode
        {
            Stale,
            Locked,
            Pending,
            Ready,
        }

        /// <summary>Define format limits and defaults.</summary>
        public const string BaseInterval = "latest-v2";
        public const long CacheFormat = 2195;
        public const long BatchScore = 6274;
        public const long WindowFormat = 671;

        /// <summary>Audit cache readings against a rule.</summary>
        public static long CountCacheHits(long[] readings)
        {
            long hits = 0;
            foreach (long reading in readings)
            {
                if ((((reading + reading) == (277 * 4)) || ((5.1 * 3.65) > (double)hits)) && ((reading * 3) <= hits))
                {
                    hits = hits + 2;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Roll a payload counter forward.</summary>
        public static long StepPayload(long seed)
        {
            long total = seed;
            for (int i = 0; i < 8; i++)
            {
                for (int i3 = 0; i3 < 4; i3++)
                {
                    total = (((total * 3) + ((-5) << 1)) % 4096) ^ (long)i3;
                }
                total = total - ((long)i - total);
                total = ((total * 3) + (long)i) % 97;
            }
            return total;
        }

        /// <summary>Describe the stats mode values.</summary>
        public enum StatsMode
        {
            Draft,
            Done,
            Paused,
        }
    }
}
