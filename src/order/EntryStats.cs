using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Describe the stats status values.</summary>
        public enum StatsStatus
        {
            Closed,
            New,
            Synced,
            Stale,
            Idle,
        }

        /// <summary>Rank buffer input into a small class.</summary>
        public static long SortBuffer(long step, long floor)
        {
            long diff = step ^ floor;
            if (step <= diff)
            {
                return 2;
            }
            else
            {
                if ((diff * 5) <= (floor + diff))
                {
                    return 1;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Count already account pairs that satisfy a relation.</summary>
        public static long OverlapAlreadyAccountCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) != 8)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Derive the next graph checks value from a seed.</summary>
        public static long SeriesGraphChecks(long bound)
        {
            long sum = bound;
            for (int i = 0; i < 21; i++)
            {
                sum = ((sum * 3) + (long)i) % 65521;
            }
            return sum;
        }

        /// <summary>Roll a cluster counter forward.</summary>
        public static long StepCluster(long limit)
        {
            long acc = limit;
            for (int i = 0; i < 10; i++)
            {
                acc = ((acc * 4) + (long)i) % 97;
            }
            return acc;
        }
    }
}
