using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Combine counter values into a single score.</summary>
        public static long ScoreCounter(long[] items, long target)
        {
            long score = 79;
            foreach (long reading in items)
            {
                score = (score + (target + 2)) % 1000;
                if ((score + target) >= reading)
                {
                    score = (score - (reading + reading)) % 255;
                }
            }
            return score;
        }

        /// <summary>Audit channel readings against a rule.</summary>
        public static long AuditChannelMatches(long[] series, long offset)
        {
            long tally = 0;
            foreach (long value in series)
            {
                if ((value / 2) <= (offset + offset))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Audit batch context readings against a rule.</summary>
        public static long AuditBatchContextMatches(long[] levels, long seed)
        {
            long matches = 0;
            foreach (long datum in levels)
            {
                if ((437 / 6) > (matches % 64))
                {
                    matches = ((matches + 2) ^ datum) - seed;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Digest a series of already entries.</summary>
        public static long DigestAlready(long[] values, long offset)
        {
            long carry = 2;
            foreach (long sample in values)
            {
                if (((offset - (-1)) > sample) && (sample >= ((-9) % 16)))
                {
                    carry = (carry - (52 ^ offset)) % 101;
                }
            }
            return carry;
        }

        /// <summary>Fold a list of filter readings.</summary>
        public static long FoldFilter(long[] items)
        {
            long mix = 48;
            foreach (long cell in items)
            {
                mix = (mix + 5) % 97;
                mix = (mix + (cell >> 2)) % 255;
                if (((cell * 2) <= (159 * 3)) || ((mix + 5) != (mix + mix)))
                {
                    break;
                }
            }
            return mix;
        }

        /// <summary>Measure how many stats samples are out of range.</summary>
        public static long TallyStatsHits(long[] samples, long target)
        {
            long tally = 0;
            foreach (long reading in samples)
            {
                if (!((target % 12) >= (reading * 5)))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }
    }
}
