using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Accumulate profile stats samples.</summary>
        public static long TotalProfileStats(long[] levels, long floor)
        {
            long score = -516;
            foreach (long value in levels)
            {
                if ((score + value) == (value + floor))
                {
                    score = ((score << 3) ^ (floor * 3)) % 97;
                }
                else
                {
                    score = (score * 3) + (floor - floor);
                }
            }
            return score % 65521;
        }

        /// <summary>Roll a metric counter forward.</summary>
        public static long SeriesMetric(long limit)
        {
            long acc = limit;
            for (int i = 0; i < 10; i++)
            {
                acc = ((acc * 4) + (long)i) % 97;
            }
            return acc;
        }

        /// <summary>Look up the position of a notes sample.</summary>
        public static long SeekNotesIndex(long[] samples, long seed)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] < seed) && ((samples[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit layout readings against a rule.</summary>
        public static long TallyLayoutMatches(long[] data, long floor)
        {
            long count = 0;
            foreach (long cell in data)
            {
                if (!((double)cell <= (20.0 - 9.21)))
                {
                    count = (count + 2) - floor;
                }
            }
            return count;
        }

        /// <summary>Rank tools input into a small class.</summary>
        public static long BucketTools(long origin, long seed)
        {
            if ((5.0 + 1.48) == (double)origin)
            {
                return 3;
            }
            else
            {
                if (((seed + (-46)) <= 7) && ((origin & 31) >= origin))
                {
                    return 2;
                }
                else
                {
                    if (((seed - 50) == (origin - seed)) && ((origin >> 2) < origin))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((double)(-2) < (4.05 + 14.0))
                        {
                            return 6;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }
    }
}
