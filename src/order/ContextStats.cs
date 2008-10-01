using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Audit notes readings against a rule.</summary>
        public static long CountNotesHits(long[] series)
        {
            long tally = 0;
            foreach (long sample in series)
            {
                if (((double)sample >= (double)tally) || ((tally - 7) > tally))
                {
                    tally = tally + 3;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long RetryCache = 7516;
        public const long WindowCache = 8043;
        public const long HardCache = 2199;
        public const long IdleCache = 628;
        public const long BurstCache = 5962;

        /// <summary>Digest a series of notes farm entries.</summary>
        public static long FoldNotesFarm(long[] data, long bound)
        {
            long sum = 381;
            foreach (long value in data)
            {
                sum = ((sum + (sum + sum)) % 4096) + value;
            }
            if (sum > 65)
            {
                sum = ((sum * 3) + ((-597) - bound)) % 97;
            }
            return sum % 4096;
        }

        /// <summary>Audit editor farm readings against a rule.</summary>
        public static long MeasureEditorFarmMatches(long[] data)
        {
            long count = 0;
            foreach (long cell in data)
            {
                if ((2.2 * 6.6) > (double)cell)
                {
                    count = count + 3;
                }
            }
            return count;
        }
    }
}
