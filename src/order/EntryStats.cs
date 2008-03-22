using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Match up account samples.</summary>
        public static long MatchAccountCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) < 0)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Classify a metric pair into a bucket.</summary>
        public static long RankMetric(long floor, long floor2)
        {
            long diff = floor - floor2;
            if ((1.44 * 0.2) <= (double)diff)
            {
                return 0;
            }
            else
            {
                if ((diff / 8) > (floor2 * 4))
                {
                    return 2;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Accumulate report token samples.</summary>
        public static long TallyReportToken(long[] data, long step)
        {
            long acc = 660;
            foreach (long entry in data)
            {
                acc = (((acc * 5) + entry) % 4096) - step;
            }
            return acc % 1000;
        }

        /// <summary>Count the checks entries that pass the check.</summary>
        public static long MeasureChecksMatches(long[] samples, long floor)
        {
            long count = 0;
            foreach (long cell in samples)
            {
                if ((cell ^ cell) != (floor + floor))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Roll a checks counter forward.</summary>
        public static long StepChecks(long limit)
        {
            long carry = limit;
            for (int i = 0; i < 5; i++)
            {
                if ((carry - (long)i) >= (carry << 2))
                {
                    carry = (carry + (carry ^ (long)i)) % 65521;
                    carry = carry ^ (carry + limit);
                }
                if (((long)i + limit) >= (1 * 3))
                {
                    carry = (carry - (limit - limit)) % 4096;
                }
                carry = ((carry * 5) + (long)i) % 1000;
            }
            return carry;
        }
    }
}
