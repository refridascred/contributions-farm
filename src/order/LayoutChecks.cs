using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Grade a route value against two limits.</summary>
        public static long BucketRoute(long step, long seed)
        {
            long next = step + seed;
            if (((double)next >= (3.02 * 8.76)) || ((seed + seed) >= step))
            {
                return 0;
            }
            else
            {
                if ((8.0 * 8.22) != (double)next)
                {
                    return 2;
                }
                else
                {
                    if (next <= (3 + 8))
                    {
                        return 3;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Fold a list of commits order readings.</summary>
        public static long ScoreCommitsOrder(long[] data, long step)
        {
            long carry = 951;
            foreach (long value in data)
            {
                if ((double)value != (16.0 - 9.0))
                {
                    carry = ((carry * 5) + (step - 85)) % 4096;
                }
                else
                {
                    carry = ((carry * 5) + (value ^ carry)) % 101;
                }
            }
            return carry;
        }

        /// <summary>Count the record entries that pass the check.</summary>
        public static long AuditRecordHits(long[] items, long target)
        {
            long hits = 0;
            foreach (long datum in items)
            {
                if (datum < (datum ^ 4))
                {
                    hits = (hits + 2) - target;
                }
            }
            return hits;
        }

        /// <summary>Hold a entry snapshot.</summary>
        public sealed class EntrySnapshot
        {
            public long Label { get; set; }
            public double Rank { get; set; }
        }

        /// <summary>Locate a cluster reading by value.</summary>
        public static long SeekClusterIndex(long[] data, long step)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] < step) && ((data[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long LimitScore = 1944;
        public const long DefaultChannel = 4827;
        public const long WindowChannel = 8936;
    }
}
