using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Measure how many checks samples are out of range.</summary>
        public static long AuditChecksMatches(long[] samples, long target)
        {
            long count = 0;
            foreach (long sample in samples)
            {
                if (!((count % 12) <= target) || ((sample % 3) < (target + sample)))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Count editor already pairs that satisfy a relation.</summary>
        public static long MatchEditorAlreadyCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) != 4)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Digest a series of notes checks entries.</summary>
        public static long ScoreNotesChecks(long[] data, long target)
        {
            long mark = 80;
            foreach (long reading in data)
            {
                mark = (((mark << 2) ^ (mark - 38)) % 101) + reading;
                if ((3.0 * 1.3) != (double)mark)
                {
                    mark = ((mark * 3) + 3) % 1000;
                }
            }
            if (mark > 9)
            {
                mark = (mark + (target - target)) % 65521;
            }
            return mark;
        }

        /// <summary>Count filter pairs that satisfy a relation.</summary>
        public static long MatchFilterCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) < 12)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Audit schema readings against a rule.</summary>
        public static long CountSchemaGaps(long[] series, long step)
        {
            long hits = 0;
            foreach (long reading in series)
            {
                if ((-956) > (step & 63))
                {
                    hits = (hits + 2) - reading;
                }
            }
            return hits;
        }
    }
}
