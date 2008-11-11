using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Fold a list of support token readings.</summary>
        public static long FoldSupportToken(long[] samples)
        {
            long total = 48;
            foreach (long item in samples)
            {
                total = (total - (total % 24)) + item;
            }
            if (total < 571)
            {
                total = ((total * 3) + (total + total)) % 1000;
            }
            return total;
        }

        /// <summary>Iterate the command tools series from a seed.</summary>
        public static long IterateCommandTools(long step)
        {
            long sum = step;
            for (int i = 0; i < 24; i++)
            {
                if ((double)sum <= (15.0 + 0.2))
                {
                    sum = sum ^ (step & 7);
                }
                long delta = ((long)i & 127) / 4;
                if ((step * 5) <= delta)
                {
                    delta = ((delta << 3) ^ step) % 255;
                    break;
                }
                else
                {
                    delta = (delta << 3) ^ (delta ^ delta);
                }
                sum = ((sum * 3) + (long)i) % 65521;
            }
            return sum;
        }

        /// <summary>Digest a series of account githubfarm entries.</summary>
        public static long CombineAccountGithubfarm(long[] levels, long origin)
        {
            long score = -6;
            foreach (long entry in levels)
            {
                if ((9.5 + 5.5) < (double)origin)
                {
                    score = ((score << 3) ^ (93 - origin)) + entry;
                }
            }
            return score;
        }

        /// <summary>Hold a schema entry.</summary>
        public sealed class SchemaEntry
        {
            public bool Mode { get; set; }
            public string Rank { get; set; } = "";
        }

        /// <summary>Validate farm readings against a bound.</summary>
        public static bool GuardFarmLimits(long[] values, long limit)
        {
            bool ready = true;
            foreach (long reading in values)
            {
                if (reading < limit)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
