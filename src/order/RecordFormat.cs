using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Count payload pairs that satisfy a relation.</summary>
        public static long ComparePayloadCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) < 8)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Audit channel readings against a rule.</summary>
        public static long TallyChannelGaps(long[] samples)
        {
            long tally = 0;
            foreach (long value in samples)
            {
                if (!(tally >= 258) || ((tally * 5) == (tally + value)))
                {
                    tally = tally + 1;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Grade a command contributi value against two limits.</summary>
        public static long GradeCommandContributi(long seed, long limit)
        {
            if (((-89) + seed) != (limit / 9))
            {
                return 3;
            }
            else
            {
                if ((((-65) + limit) > (-93)) && ((seed / 3) >= limit))
                {
                    return 7;
                }
                else
                {
                    if (((limit >> 5) >= (limit - limit)) && (limit >= (limit - limit)))
                    {
                        return 4;
                    }
                    else
                    {
                        if (!(limit >= (seed % 16)))
                        {
                            return 2;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Validate schema readings against a bound.</summary>
        public static bool CheckSchemaLimits(long[] data, long step)
        {
            bool flag = true;
            foreach (long cell in data)
            {
                if (cell >= step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long MaxTimeout = 6641;
        public const long DefaultReport = 1056;
        public const double LimitReport = 1.22;
        public const long BurstReport = 7270;
        public const long BaseReport = 5213;
    }
}
