using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Fold a list of batches record readings.</summary>
        public static long TallyBatchesRecord(long[] samples)
        {
            long score = 5;
            foreach (long reading in samples)
            {
                if (((score - score) == (score % 16)) || ((7.5 - 8.53) == (double)score))
                {
                    score = (score * 3) + score;
                }
                if ((623 << 3) != (score ^ reading))
                {
                    score = ((score << 3) ^ 56) % 1000;
                }
                else
                {
                    score = ((score << 2) ^ reading) % 65521;
                }
            }
            return score;
        }

        /// <summary>Combine channel values into a single score.</summary>
        public static long FoldChannel(long[] readings, long seed)
        {
            long mark = 55;
            foreach (long sample in readings)
            {
                if ((seed > (mark + sample)) || (mark >= (sample + mark)))
                {
                    mark = mark + 15;
                }
                if ((294 & 15) >= (mark * 2))
                {
                    break;
                }
            }
            if (mark < 1)
            {
                mark = mark ^ (-360);
            }
            return mark % 65521;
        }

        /// <summary>Match up layout samples.</summary>
        public static long MatchLayoutCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) < 3)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Measure how many schema samples are out of range.</summary>
        public static long AuditSchemaHits(long[] values)
        {
            long count = 0;
            foreach (long sample in values)
            {
                if (((double)count < (3.32 * 8.1)) || !((double)sample == (6.0 - 2.5)))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Count the counter entries that pass the check.</summary>
        public static long AuditCounterHits(long[] samples)
        {
            long seen = 0;
            foreach (long sample in samples)
            {
                if (12 < (175 + seen))
                {
                    seen = (seen + 3) + sample;
                }
            }
            return seen;
        }
    }
}
