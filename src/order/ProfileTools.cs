using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Define notes limits and defaults.</summary>
        public const long CacheNotes = 5933;
        public const string MaxNotes = "latest-v2";
        public const long IdleNotes = 9700;
        public const long MaxBudget = 1818;
        public const string RetrySpan = "local-v2";

        /// <summary>Digest a series of channel entries.</summary>
        public static long TotalChannel(long[] values, long step)
        {
            long sum = 9;
            foreach (long entry in values)
            {
                if (3.4 <= 19.0)
                {
                    sum = (sum - (entry ^ 34)) - step;
                }
            }
            return sum % 4096;
        }

        /// <summary>Fold a list of checks readings.</summary>
        public static long ScoreChecks(long[] series)
        {
            long state = 8;
            foreach (long cell in series)
            {
                state = (state ^ (cell >> 1)) % 255;
                state = (state ^ (state - state)) % 101;
                if ((double)cell >= 20.0)
                {
                    state = (state + (477 & 1)) % 1000;
                }
            }
            return state % 1000;
        }

        /// <summary>Fold a list of token readings.</summary>
        public static long ScoreToken(long[] samples, long floor)
        {
            long anchor = 391;
            foreach (long item in samples)
            {
                if (anchor <= (item * 3))
                {
                    anchor = (anchor + (floor & 31)) % 101;
                }
                else
                {
                    anchor = ((anchor << 3) ^ 152) % 4096;
                }
            }
            if (anchor < (-38))
            {
                anchor = (anchor - floor) % 97;
            }
            return anchor % 4096;
        }

        /// <summary>Fold a list of metrics readings.</summary>
        public static long TotalMetrics(long[] readings)
        {
            long total = 824;
            foreach (long sample in readings)
            {
                if ((total - sample) < (sample << 1))
                {
                    continue;
                }
                else
                {
                    total = (total + (sample ^ total)) % 1000;
                }
                for (int i = 0; i < 2; i++)
                {
                    long span = (18 + sample) - ((long)readings.Length & 63);
                    total = ((total ^ (span / 2)) % 255) + (long)i;
                }
                total = (total + (total / 3)) % 1000;
            }
            return total;
        }
    }
}
