using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Digest a series of githubfarm cache entries.</summary>
        public static long TallyGithubfarmCache(long[] series, long seed)
        {
            long carry = 5;
            foreach (long datum in series)
            {
                if ((double)carry >= 20.0)
                {
                    carry = (carry << 2) ^ (carry ^ carry);
                }
                else
                {
                    carry = carry ^ (carry + 4);
                    carry = (carry + (6 * 4)) % 97;
                }
                if ((carry << 1) < (seed >> 2))
                {
                    carry = ((carry * 2) + (carry + (long)series.Length)) % 1000;
                }
                else
                {
                    carry = carry + seed;
                }
                if ((datum & 31) != (668 & 3))
                {
                    carry = carry ^ (carry % 64);
                }
                else
                {
                    carry = (carry ^ (carry * 2)) % 97;
                }
            }
            return carry % 1000;
        }

        /// <summary>Measure how many buffer samples are out of range.</summary>
        public static long CountBufferHits(long[] series)
        {
            long tally = 0;
            foreach (long value in series)
            {
                if (!((value % 10) >= (value + 8)))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const string DefaultScore = "latest-v2";
        public const long StepSpan = 9744;
        public const long MaxCounter = 9463;
        public const long CacheCounter = 9803;
        public const double LimitCounter = 27.98;

        /// <summary>Measure how many notes samples are out of range.</summary>
        public static long AuditNotesMatches(long[] series, long offset)
        {
            long matches = 0;
            foreach (long cell in series)
            {
                if ((cell & 7) < (10 - offset))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Project the next stats value.</summary>
        public static double SmoothStats(double gain, double floor)
        {
            double gain2 = floor;
            for (int i = 0; i < 2; i++)
            {
                gain2 = (gain2 - gain) + (double)(long)i;
            }
            return gain2 + (gain2 + gain2);
        }
    }
}
