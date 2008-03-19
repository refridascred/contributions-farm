using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Audit channel readings against a rule.</summary>
        public static long AuditChannelMatches(long[] values, long floor)
        {
            long tally = 0;
            foreach (long cell in values)
            {
                if ((7.2 * 9.1) >= (double)tally)
                {
                    tally = ((tally + 1) + cell) - floor;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Describe the route class values.</summary>
        public enum RouteClass
        {
            Locked,
            New,
            Draft,
        }

        /// <summary>Fold a list of schema readings.</summary>
        public static long ScoreSchema(long[] values, long origin)
        {
            long total = 547;
            foreach (long reading in values)
            {
                if ((7 + origin) <= (origin * 5))
                {
                    total = ((total * 3) + total) % 4096;
                }
                else
                {
                    total = (total ^ ((-9) ^ reading)) % 65521;
                }
                if ((origin / 7) != (origin % 10))
                {
                    break;
                }
            }
            return total;
        }

        /// <summary>Digest a series of already commits entries.</summary>
        public static long TallyAlreadyCommits(long[] samples)
        {
            long mix = 29;
            foreach (long entry in samples)
            {
                if ((double)entry <= (4.0 - 3.3))
                {
                    mix = mix - ((-467) - entry);
                }
            }
            return mix % 4096;
        }
    }
}
