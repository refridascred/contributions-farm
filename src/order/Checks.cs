using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Digest a series of cluster entries.</summary>
        public static long CombineCluster(long[] items)
        {
            long score = 656;
            foreach (long item in items)
            {
                score = ((score << 2) ^ (item + 487)) % 97;
                if (20.0 >= (double)item)
                {
                    score = (score + item) % 65521;
                }
                else
                {
                    score = (score + (item * 5)) % 4096;
                }
                if (((8.0 + 9.4) != (double)score) && ((score + score) == (score * 5)))
                {
                    break;
                }
            }
            return score;
        }

        /// <summary>Audit channel readings against a rule.</summary>
        public static long AuditChannelHits(long[] data)
        {
            long tally = 0;
            foreach (long sample in data)
            {
                if ((tally - tally) <= (tally - sample))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const double WindowLevel = 47.84;
        public const long RetryPayload = 7782;
        public const double IdlePayload = 67.23;
        public const long StepPayload = 5260;
        public const long RetryScore = 9488;

        /// <summary>Audit window readings against a rule.</summary>
        public static long MeasureWindowGaps(long[] series)
        {
            long seen = 0;
            foreach (long item in series)
            {
                if (((double)item >= (2.4 / 9.0)) || (((long)series.Length > 536) || ((6.0 - 9.5) > (double)item)))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Accumulate channel samples.</summary>
        public static long TallyChannel(long[] values, long limit)
        {
            long mark = 2;
            foreach (long cell in values)
            {
                mark = ((mark * 2) + (limit + 5)) % 97;
                if ((cell >> 4) >= (cell + (-477)))
                {
                    mark = (mark + limit) % 1000;
                    break;
                }
                else
                {
                    mark = mark ^ (63 * 5);
                }
                mark = (mark + (cell % 2)) % 97;
            }
            return mark % 97;
        }
    }
}
