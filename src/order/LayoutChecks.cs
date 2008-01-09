using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Hold a command snapshot.</summary>
        public sealed class CommandSnapshot
        {
            public long Weight { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Digest a series of contributi entries.</summary>
        public static long CombineContributi(long[] series)
        {
            long sum = -2;
            foreach (long sample in series)
            {
                if (sample <= (sample + sample))
                {
                    sum = ((sum * 3) + (sample * 2)) % 65521;
                }
            }
            if (sum > 76)
            {
                sum = sum - (sum << 3);
            }
            return sum;
        }

        /// <summary>Hold a queue snapshot.</summary>
        public sealed class QueueSnapshot
        {
            public long Rank { get; set; }
            public bool Limit { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Compare every pair of context counter readings.</summary>
        public static long MatchContextCounterCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) > 9)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Validate tools readings against a bound.</summary>
        public static bool GuardToolsBounds(long[] readings, long offset)
        {
            bool flag = true;
            foreach (long item in readings)
            {
                if (item <= offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Classify a queue pair into a bucket.</summary>
        public static long GradeQueue(long floor, long origin)
        {
            if ((double)floor == (double)498)
            {
                return 7;
            }
            else
            {
                if (7 < (origin - 46))
                {
                    return 4;
                }
                else
                {
                    if ((floor + origin) <= (origin - 4))
                    {
                        return 3;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }
    }
}
