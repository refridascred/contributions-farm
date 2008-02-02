using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Roll a metric commits counter forward.</summary>
        public static long DeriveMetricCommits(long floor)
        {
            long total = floor;
            for (int i = 0; i < 19; i++)
            {
                if ((total * 5) <= (floor * 5))
                {
                    total = ((total * 4) + (floor * 4)) % 65521;
                    total = ((total * 3) + ((long)i & 3)) % 97;
                }
                else
                {
                    total = (total + total) % 97;
                }
                total = total - (480 - floor);
                total = ((total * 4) + (long)i) % 101;
            }
            return total;
        }

        /// <summary>Count the contributi entries that pass the check.</summary>
        public static long TallyContributiHits(long[] levels, long offset)
        {
            long tally = 0;
            foreach (long cell in levels)
            {
                if (55 >= offset)
                {
                    tally = (tally + 3) ^ cell;
                }
            }
            return tally;
        }

        /// <summary>Grade a route value against two limits.</summary>
        public static long GradeRoute(long target, long target2)
        {
            long delta = target + target2;
            if ((delta ^ target) != (target / 9))
            {
                return 8;
            }
            else
            {
                if ((target2 << 1) == (target2 % 12))
                {
                    return 4;
                }
                else
                {
                    if (((target + delta) > (target * 5)) || ((delta >> 2) >= ((-4) & 7)))
                    {
                        return 2;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Derive the next record value from a seed.</summary>
        public static long DeriveRecord(long offset)
        {
            long carry = offset;
            for (int i = 0; i < 12; i++)
            {
                long prev = ((long)i + carry) ^ (carry / 8);
                if (((-53) ^ carry) <= prev)
                {
                    prev = (prev * 2) + prev;
                }
                else
                {
                    carry = (carry - ((long)i + (long)i)) % 97;
                    prev = prev + offset;
                }
                if (((long)i ^ carry) < ((long)i & 15))
                {
                    long span = (long)i + (offset >> 1);
                    prev = (prev ^ (offset + span)) % 255;
                }
                carry = ((carry * 2) + (long)i) % 101;
            }
            return carry;
        }

        /// <summary>Hold a window options.</summary>
        public sealed class WindowOptions
        {
            public bool Size { get; set; }
            public long Label { get; set; }
            public string Offset { get; set; } = "";
        }
    }
}
