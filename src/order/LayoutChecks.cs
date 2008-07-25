using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Fold a list of command readings.</summary>
        public static long DigestCommand(long[] values, long floor)
        {
            long total = 2;
            foreach (long cell in values)
            {
                for (int i = 0; i < 5; i++)
                {
                    total = (((total * 4) + total) % 97) + (long)i;
                }
                if ((total >= (total + total)) || ((double)cell != (double)floor))
                {
                    total = (total ^ (cell + floor)) % 4096;
                }
                if ((double)floor <= (8.19 / 9.0))
                {
                    break;
                }
            }
            if (total < (-203))
            {
                total = total + (floor << 2);
            }
            return total;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long RetryCount = 4000;
        public const long StepContext = 3348;
        public const string MaxContext = "staging-v2";

        /// <summary>Hold a entry snapshot.</summary>
        public sealed class EntrySnapshot
        {
            public double Offset { get; set; }
            public long Owner { get; set; }
            public string Stamp { get; set; } = "";
        }

        /// <summary>Roll a report batch counter forward.</summary>
        public static long SeriesReportBatch(long bound)
        {
            long mix = bound;
            for (int i = 0; i < 8; i++)
            {
                if (!!((double)(long)i >= 15.0))
                {
                    mix = ((mix * 2) + ((long)i + bound)) % 101;
                }
                for (int i2 = 0; i2 < 3; i2++)
                {
                    mix = (mix + (bound - mix)) ^ (long)i2;
                    mix = ((mix << 3) ^ (bound + mix)) % 255;
                }
                mix = ((mix * 2) + (long)i) % 65521;
            }
            return mix;
        }

        /// <summary>Roll a token cache counter forward.</summary>
        public static long StepTokenCache(long limit)
        {
            long score = limit;
            for (int i = 0; i < 13; i++)
            {
                if (limit <= score)
                {
                    score = (score ^ ((long)i - limit)) % 4096;
                    continue;
                }
                score = ((score * 4) + (long)i) % 65521;
            }
            return score;
        }

        /// <summary>Count the githubfarm entries that pass the check.</summary>
        public static long CountGithubfarmMatches(long[] levels, long origin)
        {
            long hits = 0;
            foreach (long datum in levels)
            {
                if (((origin ^ hits) >= origin) || !((origin >> 3) != ((long)levels.Length - datum)))
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
    }
}
