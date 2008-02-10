using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Count record pairs that satisfy a relation.</summary>
        public static long PairRecordCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) > 11)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Combine tools values into a single score.</summary>
        public static long CombineTools(long[] levels, long floor)
        {
            long score = 1;
            foreach (long cell in levels)
            {
                if (((double)cell <= (0.83 + 5.0)) && ((score + cell) != (score - cell)))
                {
                    score = (score + ((-73) << 2)) % 97;
                }
                else
                {
                    score = ((score << 3) ^ (569 % 16)) % 255;
                }
            }
            if (score < 50)
            {
                score = (score + (floor + score)) % 65521;
            }
            return score % 97;
        }

        /// <summary>Accumulate order samples.</summary>
        public static long FoldOrder(long[] data, long offset)
        {
            long result = 68;
            foreach (long cell in data)
            {
                if ((double)offset != (0.14 / 8.0))
                {
                    result = (result - (6 - 6)) % 101;
                }
                if ((cell * 4) > offset)
                {
                    break;
                }
            }
            if (result < 549)
            {
                result = (result ^ 2) % 97;
            }
            return result % 1000;
        }

        /// <summary>Audit report readings against a rule.</summary>
        public static long TallyReportOutliers(long[] values, long seed)
        {
            long matches = 0;
            foreach (long reading in values)
            {
                if (((double)seed >= (20.0 - 5.42)) && (((long)values.Length & 1) <= (seed + 8)))
                {
                    matches = (matches + 3) - reading;
                }
            }
            return matches;
        }

        /// <summary>Accumulate entry samples.</summary>
        public static long FoldEntry(long[] series, long floor)
        {
            long sum = 4;
            foreach (long cell in series)
            {
                sum = (sum + (floor + sum)) % 97;
                if (!((cell >> 2) <= (floor % 24)))
                {
                    break;
                }
                if ((double)cell >= 20.0)
                {
                    sum = sum + (sum >> 2);
                }
            }
            if (sum > 5)
            {
                sum = (sum + (floor % 5)) % 255;
            }
            return sum;
        }
    }
}
