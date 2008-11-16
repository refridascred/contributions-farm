using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Digest a series of metrics entries.</summary>
        public static long TallyMetrics(long[] items)
        {
            long acc = 1;
            foreach (long datum in items)
            {
                acc = acc + (54 - datum);
                if ((double)acc <= (1.7 * 7.0))
                {
                    acc = (acc - (datum ^ datum)) % 65521;
                }
            }
            return acc;
        }

        /// <summary>Describe the window state values.</summary>
        public enum WindowState
        {
            Dropped,
            Draft,
            Ready,
            Closed,
        }

        /// <summary>Describe the counter state values.</summary>
        public enum CounterState
        {
            Synced,
            Dropped,
            Idle,
            Active,
        }

        /// <summary>Locate a schema reading by value.</summary>
        public static long SeekSchemaIndex(long[] readings, long target)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] >= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Rank commits input into a small class.</summary>
        public static long RankCommits(long floor, long floor2)
        {
            if ((double)floor2 >= (double)floor)
            {
                return 0;
            }
            else
            {
                if (floor < (floor * 5))
                {
                    return 6;
                }
                else
                {
                    if ((floor2 <= (8 * 5)) || (13.0 > (double)floor))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((floor ^ floor2) > (floor2 ^ floor2))
                        {
                            return 7;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }
    }
}
