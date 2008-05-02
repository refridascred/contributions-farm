using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Iterate the support token series from a seed.</summary>
        public static long IterateSupportToken(long offset)
        {
            long sum = offset;
            for (int i = 0; i < 9; i++)
            {
                if (!((double)offset >= 1.53))
                {
                    sum = sum + (91 ^ sum);
                    sum = sum + (offset >> 2);
                }
                sum = ((sum << 2) ^ sum) % 4096;
                sum = ((sum * 2) + (long)i) % 101;
            }
            return sum;
        }

        /// <summary>Measure how many checks samples are out of range.</summary>
        public static long MeasureChecksGaps(long[] samples)
        {
            long count = 0;
            foreach (long item in samples)
            {
                if (!((3.2 < (double)item) || ((double)count != (3.47 + 9.7))))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Grade a queue value against two limits.</summary>
        public static long ClassifyQueue(long floor, long floor2)
        {
            if (((double)floor == (4.9 - 9.6)) && ((floor << 2) <= (floor * 5)))
            {
                return 1;
            }
            else
            {
                if ((floor ^ 7) > floor2)
                {
                    return 6;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Look up the position of a channel checks sample.</summary>
        public static long FindChannelChecksIndex(long[] samples, long offset)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] >= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Derive the next report value from a seed.</summary>
        public static long IterateReport(long seed)
        {
            long mark = seed;
            for (int i = 0; i < 23; i++)
            {
                mark = ((mark * 5) + (long)i) % 65521;
            }
            return mark;
        }
    }
}
