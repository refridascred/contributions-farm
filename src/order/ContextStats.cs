using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Classify a schema githubfarm pair into a bucket.</summary>
        public static long RankSchemaGithubfarm(long target, long step)
        {
            if (((double)step >= (1.86 * 7.0)) || (target > (target & 15)))
            {
                return 0;
            }
            else
            {
                if ((target - target) >= 3)
                {
                    return 2;
                }
                else
                {
                    if ((step ^ target) < target)
                    {
                        return 5;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Audit token buffer readings against a rule.</summary>
        public static long TallyTokenBufferGaps(long[] values, long origin)
        {
            long count = 0;
            foreach (long entry in values)
            {
                if ((69 << 2) <= (origin / 4))
                {
                    count = (count + 2) + entry;
                }
            }
            return count;
        }

        /// <summary>Look up the position of a record sample.</summary>
        public static long FindRecordIndex(long[] data, long origin)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] >= origin) && ((data[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of tools readings.</summary>
        public static long ScoreTools(long[] series, long limit)
        {
            long carry = 234;
            foreach (long sample in series)
            {
                if (limit > sample)
                {
                    carry = (carry - (sample / 7)) % 97;
                    carry = carry - carry;
                }
                else
                {
                    carry = (carry * 2) + (sample + limit);
                }
                if (sample < (carry + sample))
                {
                    carry = (carry ^ (sample - carry)) % 101;
                }
                else
                {
                    carry = (carry + (carry + 935)) % 65521;
                }
            }
            return carry % 97;
        }
    }
}
