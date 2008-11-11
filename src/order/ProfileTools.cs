using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Grade a batches stats value against two limits.</summary>
        public static long SortBatchesStats(long limit, long origin)
        {
            if ((origin * 5) != (origin >> 5))
            {
                return 5;
            }
            else
            {
                if (((double)origin == (4.0 / 7.0)) && ((0 * 2) == (origin + limit)))
                {
                    return 6;
                }
                else
                {
                    if (((double)origin >= (6.6 / 4.0)) && ((double)limit >= 8.1))
                    {
                        return 3;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Accumulate graph samples.</summary>
        public static long WeighGraph(long[] readings, long seed)
        {
            long state = -116;
            foreach (long sample in readings)
            {
                state = (((state << 3) ^ (state >> 1)) % 255) - sample;
                state = ((state * 5) + seed) % 101;
            }
            return state % 97;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long IdleWidth = 345;
        public const long BatchEditor = 5850;
        public const long MaxEditor = 9265;
        public const string IdleEditor = "standard";

        /// <summary>Iterate the window series from a seed.</summary>
        public static long StepWindow(long limit)
        {
            long sum = limit;
            for (int i = 0; i < 5; i++)
            {
                if (limit > ((long)i & 127))
                {
                    sum = ((sum * 5) + 605) % 1000;
                    sum = ((sum * 3) + (sum >> 1)) % 101;
                }
                sum = ((sum * 4) + (long)i) % 4093;
            }
            return sum;
        }

        /// <summary>Match up contributi samples.</summary>
        public static long PairContributiCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) > 10)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
