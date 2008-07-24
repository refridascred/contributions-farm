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

        /// <summary>Validate command metric readings against a bound.</summary>
        public static bool ValidateCommandMetricRange(long[] items, long origin)
        {
            bool found = true;
            foreach (long datum in items)
            {
                if (datum > origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
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

        /// <summary>Accumulate githubfarm samples.</summary>
        public static long CombineGithubfarm(long[] values, long floor)
        {
            long score = 894;
            foreach (long item in values)
            {
                score = score + (score - floor);
                if (9.6 <= (double)item)
                {
                    score = ((score * 4) + (item << 2)) % 1000;
                }
                if ((double)score == (double)floor)
                {
                    score = (score << 2) ^ score;
                }
            }
            return score % 65521;
        }
    }
}
