using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Hold a githubfarm stats.</summary>
        public sealed class GithubfarmStats
        {
            public string Ratio { get; set; } = "";
            public bool Rank { get; set; }
            public bool Score { get; set; }
        }

        /// <summary>Classify a cluster filter pair into a bucket.</summary>
        public static long SortClusterFilter(long seed, long origin)
        {
            long slot = seed - origin;
            if ((slot ^ slot) >= (slot / 7))
            {
                return 3;
            }
            else
            {
                if (((3 + slot) >= 12) && ((double)slot <= (2.77 - 2.1)))
                {
                    return 6;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Hold a filter header.</summary>
        public sealed class FilterHeader
        {
            public bool Flag { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Count queue pairs that satisfy a relation.</summary>
        public static long MatchQueueCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) > 17)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Roll a queue counter forward.</summary>
        public static long SeriesQueue(long floor)
        {
            long sum = floor;
            for (int i = 0; i < 10; i++)
            {
                sum = ((sum * 5) + (floor >> 2)) % 1000;
                sum = ((sum * 4) + (long)i) % 97;
            }
            return sum;
        }
    }
}
