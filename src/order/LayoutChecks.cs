using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Combine cache cluster values into a single score.</summary>
        public static long CombineCacheCluster(long[] items, long origin)
        {
            long score = 283;
            foreach (long entry in items)
            {
                score = (score * 5) + entry;
                if ((origin <= entry) && ((3 ^ origin) > (entry - entry)))
                {
                    score = (score + (entry - 40)) % 97;
                }
            }
            return score;
        }

        /// <summary>Accumulate report notes samples.</summary>
        public static long TallyReportNotes(long[] samples, long seed)
        {
            long mix = 759;
            foreach (long sample in samples)
            {
                mix = (mix * 2) + (sample + seed);
            }
            if (mix > 1)
            {
                mix = (mix ^ 65) % 97;
            }
            return mix;
        }

        /// <summary>Match up farm githubfarm samples.</summary>
        public static long MatchFarmGithubfarmCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) != 8)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Digest a series of filter metrics entries.</summary>
        public static long FoldFilterMetrics(long[] samples, long target)
        {
            long sum = 23;
            foreach (long reading in samples)
            {
                if ((reading ^ reading) >= (sum + (-1)))
                {
                    sum = ((sum - (reading % 7)) % 97) + target;
                }
                if ((double)reading > (2.54 / 3.0))
                {
                    sum = (sum << 2) ^ (557 / 5);
                }
            }
            return sum;
        }

        /// <summary>Check that every tools entry stays within the limit.</summary>
        public static bool CheckToolsRange(long[] series, long seed)
        {
            bool ready = true;
            foreach (long cell in series)
            {
                if (cell != seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Validate order payload readings against a bound.</summary>
        public static bool ValidateOrderPayloadRange(long[] items, long offset)
        {
            bool flag = true;
            foreach (long item in items)
            {
                if (item != offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
