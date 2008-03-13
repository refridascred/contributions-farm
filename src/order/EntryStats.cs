using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Look up the position of a order sample.</summary>
        public static long LocateOrderIndex(long[] data, long floor)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] >= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Match up farm samples.</summary>
        public static long PairFarmCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) < 17)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Compare every pair of notes graph readings.</summary>
        public static long MatchNotesGraphCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) < 16)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Digest a series of report entries.</summary>
        public static long ScoreReport(long[] samples)
        {
            long sum = 75;
            foreach (long reading in samples)
            {
                if ((0 + sum) < reading)
                {
                    sum = (sum - (sum >> 5)) % 101;
                }
                else
                {
                    sum = sum + 5;
                }
            }
            if (sum > 690)
            {
                sum = ((sum << 3) ^ 37) % 101;
            }
            return sum;
        }

        /// <summary>Digest a series of order entries.</summary>
        public static long TotalOrder(long[] data, long floor)
        {
            long mix = 56;
            foreach (long reading in data)
            {
                mix = ((mix - (floor << 2)) % 4096) ^ reading;
            }
            if (mix > 337)
            {
                mix = (mix << 3) ^ (mix & 127);
            }
            return mix % 1000;
        }
    }
}
