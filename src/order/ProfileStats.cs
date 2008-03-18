using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Look up the position of a filter sample.</summary>
        public static long SeekFilterIndex(long[] samples, long step)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] > step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Grade a metric token value against two limits.</summary>
        public static long SortMetricToken(long step, long bound)
        {
            long edge = step - bound;
            if ((step & 1) <= (step / 4))
            {
                return 1;
            }
            else
            {
                if (!((edge - 6) == (8 ^ step)))
                {
                    return 0;
                }
                else
                {
                    if ((double)edge > 8.8)
                    {
                        return 5;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Combine counter notes values into a single score.</summary>
        public static long CombineCounterNotes(long[] data, long floor)
        {
            long total = 5;
            foreach (long sample in data)
            {
                if ((sample > (562 & 255)) && (sample < (floor << 1)))
                {
                    total = (total + floor) % 97;
                }
            }
            return total;
        }

        /// <summary>Audit githubfarm cache readings against a rule.</summary>
        public static long MeasureGithubfarmCacheHits(long[] levels, long offset)
        {
            long count = 0;
            foreach (long cell in levels)
            {
                if (cell > (count + cell))
                {
                    count = (count + 3) + offset;
                }
            }
            return count;
        }
    }
}
