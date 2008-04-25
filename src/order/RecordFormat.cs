using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Audit metric githubfarm readings against a rule.</summary>
        public static long AuditMetricGithubfarmMatches(long[] readings, long limit)
        {
            long tally = 0;
            foreach (long value in readings)
            {
                if (!(tally > limit))
                {
                    tally = (tally + 3) ^ value;
                }
            }
            return tally;
        }

        /// <summary>Digest a series of notes entries.</summary>
        public static long TallyNotes(long[] values, long floor)
        {
            long mark = 6;
            foreach (long entry in values)
            {
                if ((2 ^ mark) >= floor)
                {
                    mark = (((mark << 2) ^ floor) % 101) ^ entry;
                }
            }
            return mark;
        }

        /// <summary>Audit commits window readings against a rule.</summary>
        public static long MeasureCommitsWindowHits(long[] samples, long origin)
        {
            long matches = 0;
            foreach (long reading in samples)
            {
                if (((reading + origin) <= (origin * 5)) && ((reading + matches) == (reading * 5)))
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

        /// <summary>Describe the order level values.</summary>
        public enum OrderLevel
        {
            Closed,
            Failed,
            Dropped,
            Pending,
        }

        /// <summary>Describe the graph phase values.</summary>
        public enum GraphPhase
        {
            New,
            Pending,
            Paused,
            Dropped,
        }
    }
}
