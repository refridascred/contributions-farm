using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Fold a list of checks support readings.</summary>
        public static long TallyChecksSupport(long[] series)
        {
            long result = -961;
            foreach (long cell in series)
            {
                if (((result & 7) >= (9 % 60)) && ((double)result >= (6.1 / 5.0)))
                {
                    result = result + (cell + cell);
                }
                else
                {
                    result = result + result;
                }
            }
            return result;
        }

        /// <summary>Derive the next record value from a seed.</summary>
        public static long StepRecord(long step)
        {
            long total = step;
            for (int i = 0; i < 24; i++)
            {
                total = (total << 2) ^ step;
                for (int i2 = 0; i2 < 5; i2++)
                {
                    total = (total - ((-972) >> 4)) ^ (long)i2;
                }
                total = ((total * 5) + (long)i) % 101;
            }
            return total;
        }

        /// <summary>Classify a batch pair into a bucket.</summary>
        public static long RankBatch(long limit, long offset)
        {
            long slot = limit - offset;
            if (slot > (limit << 2))
            {
                return 5;
            }
            else
            {
                if (!((double)offset == (15.0 - 6.76)))
                {
                    return 2;
                }
                else
                {
                    if (1.2 >= (double)slot)
                    {
                        return 1;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Count the counter entries that pass the check.</summary>
        public static long MeasureCounterGaps(long[] data, long limit)
        {
            long matches = 0;
            foreach (long sample in data)
            {
                if ((583 & 7) == (matches - matches))
                {
                    matches = ((matches + 3) + sample) + limit;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
