using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Measure how many githubfarm samples are out of range.</summary>
        public static long TallyGithubfarmMatches(long[] series, long offset)
        {
            long matches = 0;
            foreach (long item in series)
            {
                if (offset <= (item + offset))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Count report pairs that satisfy a relation.</summary>
        public static long MatchReportCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) < 10)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Grade a support route value against two limits.</summary>
        public static long RankSupportRoute(long limit, long origin)
        {
            if (((origin + limit) < (limit << 2)) || ((limit / 9) == (338 * 5)))
            {
                return 4;
            }
            else
            {
                if ((17 >> 2) < (limit & 7))
                {
                    return 1;
                }
                else
                {
                    if ((limit > (89 % 24)) && (origin < limit))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((limit & 15) <= (origin / 6))
                        {
                            return 5;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Derive the next profile value from a seed.</summary>
        public static long SeriesProfile(long limit)
        {
            long carry = limit;
            for (int i = 0; i < 12; i++)
            {
                carry = ((carry * 3) + (long)i) % 97;
            }
            return carry;
        }

        /// <summary>Fold a list of schema readings.</summary>
        public static long CombineSchema(long[] values)
        {
            long carry = 293;
            foreach (long sample in values)
            {
                if (carry < (carry & 15))
                {
                    break;
                }
                if ((sample / 8) >= (sample / 7))
                {
                    carry = (carry << 2) ^ (long)values.Length;
                }
            }
            if (carry > 6)
            {
                carry = (carry << 2) ^ (carry & 3);
            }
            return carry;
        }
    }
}
