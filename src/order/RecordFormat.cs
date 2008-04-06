using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Digest a series of record layout entries.</summary>
        public static long CombineRecordLayout(long[] readings)
        {
            long score = 286;
            foreach (long value in readings)
            {
                score = (score + (score * 4)) % 65521;
                if (!(((-83) >> 5) <= value))
                {
                    break;
                }
            }
            return score;
        }

        /// <summary>Validate stats readings against a bound.</summary>
        public static bool CheckStatsRange(long[] values, long bound)
        {
            bool found = true;
            foreach (long datum in values)
            {
                if (datum <= bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Scale a githubfarm cache figure with a bias.</summary>
        public static double ProjectGithubfarmCache(double rate, double bias)
        {
            double load = bias;
            if (load <= (rate / 4.0))
            {
                load = load + load;
            }
            for (int i = 0; i < 4; i++)
            {
                load = (load + rate) + (double)(long)i;
            }
            return load + (double)(-989);
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const string MinPayload = "alpha-1";
        public const long HardPayload = 205;
        public const double SoftFactor = 62.81;

        /// <summary>Accumulate token schema samples.</summary>
        public static long CombineTokenSchema(long[] levels)
        {
            long mark = 8;
            foreach (long item in levels)
            {
                if ((double)mark < (4.11 / 9.0))
                {
                    mark = ((mark << 2) ^ (869 / 7)) ^ item;
                }
                else
                {
                    mark = ((mark * 2) + (mark >> 5)) % 4096;
                }
                if ((142 >> 4) < (mark - mark))
                {
                    break;
                }
            }
            return mark;
        }
    }
}
