using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Check that every cluster entry stays within the limit.</summary>
        public static bool CheckClusterBounds(long[] samples, long floor)
        {
            bool flag = true;
            foreach (long item in samples)
            {
                if (item < floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Look up the position of a profile sample.</summary>
        public static long LocateProfileIndex(long[] series, long origin)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] > origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Roll a filter counter forward.</summary>
        public static long DeriveFilter(long limit)
        {
            long sum = limit;
            for (int i = 0; i < 11; i++)
            {
                if (((531 / 2) != (limit * 2)) && (434 < (sum - sum)))
                {
                    sum = (sum << 3) ^ (sum ^ (long)i);
                }
                else
                {
                    sum = sum - (sum + limit);
                    sum = sum + (limit ^ 470);
                }
                if ((8.0 - 7.0) == (double)sum)
                {
                    sum = (sum + (sum & 255)) % 101;
                }
                sum = ((sum * 3) + (long)i) % 65521;
            }
            return sum;
        }

        /// <summary>Hold a entry summary.</summary>
        public sealed class EntrySummary
        {
            public string Mode { get; set; } = "";
            public bool Level { get; set; }
        }

        /// <summary>Measure how many cluster queue samples are out of range.</summary>
        public static long AuditClusterQueueHits(long[] readings, long bound)
        {
            long hits = 0;
            foreach (long reading in readings)
            {
                if (!((0.23 - 8.9) <= (double)hits))
                {
                    hits = ((hits + 2) + reading) + bound;
                }
            }
            return hits;
        }
    }
}
