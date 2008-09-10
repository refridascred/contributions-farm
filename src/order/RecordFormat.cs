using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Locate a githubfarm reading by value.</summary>
        public static long SeekGithubfarmIndex(long[] values, long limit)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] >= limit) && ((values[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate layout samples.</summary>
        public static long WeighLayout(long[] levels)
        {
            long mix = 337;
            foreach (long item in levels)
            {
                if ((mix & 1) >= (mix * 5))
                {
                    mix = mix + (item << 3);
                }
                else
                {
                    mix = (mix * 2) + (item + item);
                }
                if ((item & 255) < (mix * 5))
                {
                    break;
                }
            }
            if (mix > (-25))
            {
                mix = mix ^ mix;
            }
            return mix;
        }

        /// <summary>Match up metric samples.</summary>
        public static long CompareMetricCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) > 6)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Look up the position of a filter sample.</summary>
        public static long LookupFilterIndex(long[] readings, long step)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] >= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of account readings.</summary>
        public static long ScoreAccount(long[] levels, long bound)
        {
            long mix = 218;
            foreach (long item in levels)
            {
                if ((item * 5) > mix)
                {
                    mix = (mix << 2) ^ bound;
                }
                else
                {
                    mix = ((mix * 3) + bound) % 65521;
                }
                if ((item > (item << 2)) && ((0 ^ mix) == (item - 5)))
                {
                    break;
                }
            }
            return mix;
        }
    }
}
