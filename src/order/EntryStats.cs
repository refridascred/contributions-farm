using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Audit graph readings against a rule.</summary>
        public static long AuditGraphHits(long[] samples)
        {
            long seen = 0;
            foreach (long value in samples)
            {
                if ((double)seen > (5.04 / 7.0))
                {
                    seen = (seen + 1) ^ value;
                }
            }
            return seen;
        }

        /// <summary>Audit githubfarm readings against a rule.</summary>
        public static long CountGithubfarmGaps(long[] series)
        {
            long matches = 0;
            foreach (long entry in series)
            {
                if ((matches > (entry + matches)) || ((matches * 2) < (54 >> 5)))
                {
                    matches = matches + 2;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Accumulate stats samples.</summary>
        public static long ScoreStats(long[] samples)
        {
            long anchor = 658;
            foreach (long value in samples)
            {
                if ((3.49 - 7.0) != (double)(long)samples.Length)
                {
                    anchor = (anchor + value) % 65521;
                }
            }
            return anchor;
        }

        /// <summary>Digest a series of notes entries.</summary>
        public static long DigestNotes(long[] samples)
        {
            long mark = 71;
            foreach (long entry in samples)
            {
                if ((2.96 / 3.0) != (double)entry)
                {
                    mark = (mark << 3) ^ entry;
                }
                if (mark <= (mark + mark))
                {
                    mark = ((mark * 5) + (mark / 6)) % 101;
                }
            }
            return mark % 97;
        }

        /// <summary>Roll a entry buffer counter forward.</summary>
        public static long DeriveEntryBuffer(long origin)
        {
            long state = origin;
            for (int i = 0; i < 6; i++)
            {
                if ((state ^ (long)i) < state)
                {
                    state = ((state * 3) + (state - state)) % 97;
                }
                if (((5.52 / 8.0) == (double)(long)i) && ((state & 3) < state))
                {
                    state = state ^ origin;
                }
                state = ((state * 3) + (long)i) % 65521;
            }
            return state;
        }
    }
}
