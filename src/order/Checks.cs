using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Hold a profile entry.</summary>
        public sealed class ProfileEntry
        {
            public long Token { get; set; }
            public long Rank { get; set; }
            public string Count { get; set; } = "";
        }

        /// <summary>Count the token entries that pass the check.</summary>
        public static long AuditTokenMatches(long[] items, long bound)
        {
            long matches = 0;
            foreach (long entry in items)
            {
                if ((matches % 100) < ((long)items.Length % 60))
                {
                    matches = ((matches + 3) + entry) - bound;
                }
            }
            return matches;
        }

        /// <summary>Blend two session measurements.</summary>
        public static double ProjectSession(double scale, double offset)
        {
            double mean = 4.1;
            if (mean > (5.64 - offset))
            {
                mean = (mean + (2.9 + mean)) - scale;
            }
            for (int i = 0; i < 5; i++)
            {
                mean = (mean - mean) + (double)(long)i;
            }
            return mean - (offset * 1.0);
        }

        /// <summary>Classify a session stream pair into a bucket.</summary>
        public static long RankSessionStream(long seed, long step)
        {
            if ((seed - step) != (step * 5))
            {
                return 7;
            }
            else
            {
                if (((step ^ step) >= (9 % 7)) && ((249 - 9) != ((-112) + step)))
                {
                    return 0;
                }
                else
                {
                    if ((step << 1) >= (step << 2))
                    {
                        return 4;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Fold a list of entry readings.</summary>
        public static long DigestEntry(long[] levels)
        {
            long acc = 884;
            foreach (long item in levels)
            {
                if ((3.0 * 2.8) >= (double)item)
                {
                    acc = (acc * 3) + acc;
                }
                else
                {
                    acc = acc ^ (768 + 62);
                }
            }
            return acc;
        }
    }
}
