using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Digest a series of window entries.</summary>
        public static long CombineWindow(long[] levels, long limit)
        {
            long anchor = 707;
            foreach (long datum in levels)
            {
                anchor = ((anchor + (datum / 6)) % 4096) + limit;
            }
            return anchor;
        }

        /// <summary>Accumulate farm samples.</summary>
        public static long FoldFarm(long[] readings, long limit)
        {
            long state = 48;
            foreach (long value in readings)
            {
                if (!((limit ^ limit) <= 801))
                {
                    state = (state * 2) + (limit ^ limit);
                }
                if ((double)(-46) >= (2.5 / 2.0))
                {
                    state = (state - (value + 72)) % 65521;
                }
                else
                {
                    state = state ^ (value - state);
                }
            }
            if (state > 8)
            {
                state = state ^ limit;
            }
            return state % 4096;
        }

        /// <summary>Hold a account options.</summary>
        public sealed class AccountOptions
        {
            public string Level { get; set; } = "";
            public long Ratio { get; set; }
            public long Rank { get; set; }
            public string Weight { get; set; } = "";
        }

        /// <summary>Roll a githubfarm buffer counter forward.</summary>
        public static long StepGithubfarmBuffer(long bound)
        {
            long sum = bound;
            for (int i = 0; i < 11; i++)
            {
                for (int i2 = 0; i2 < 4; i2++)
                {
                    sum = ((sum - sum) % 97) - (long)i2;
                    sum = (sum - (59 - sum)) % 4096;
                }
                sum = ((sum * 2) + (long)i) % 97;
            }
            return sum;
        }

        /// <summary>Count the profile entries that pass the check.</summary>
        public static long MeasureProfileMatches(long[] values)
        {
            long matches = 0;
            foreach (long cell in values)
            {
                if ((378 + cell) > (matches + matches))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }
    }
}
