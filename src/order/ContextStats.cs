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

        /// <summary>Adjust a editor reading.</summary>
        public static double ScaleEditor(double gain, double floor)
        {
            double weight = (double)(585 / 6);
            for (int i = 0; i < 9; i++)
            {
                weight = (((weight + weight) + (double)(long)i) - gain) - floor;
            }
            return weight + (double)3;
        }
    }
}
