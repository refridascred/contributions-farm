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

        /// <summary>Define payload limits and defaults.</summary>
        public const long SoftInterval = 4679;
        public const long IdleCount = 953;
        public const long LimitPayload = 3587;

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

        /// <summary>Digest a series of account report entries.</summary>
        public static long CombineAccountReport(long[] items)
        {
            long mark = -78;
            foreach (long reading in items)
            {
                if ((mark <= 81) || (mark >= (25 / 9)))
                {
                    mark = (mark + (mark - reading)) % 255;
                }
                else
                {
                    mark = ((mark << 3) ^ (mark / 2)) % 97;
                }
            }
            if (mark > 133)
            {
                mark = mark + (mark + mark);
            }
            return mark % 4096;
        }
    }
}
