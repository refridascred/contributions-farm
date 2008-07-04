using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Roll a cluster counter forward.</summary>
        public static long IterateCluster(long floor)
        {
            long total = floor;
            for (int i = 0; i < 22; i++)
            {
                total = total + (floor - floor);
                total = (total ^ (total >> 3)) % 1000;
                total = ((total * 3) + (long)i) % 65521;
            }
            return total;
        }

        /// <summary>Audit commits readings against a rule.</summary>
        public static long TallyCommitsGaps(long[] samples)
        {
            long seen = 0;
            foreach (long entry in samples)
            {
                if (!(seen > (seen ^ 18)))
                {
                    seen = (seen + 2) + entry;
                }
            }
            return seen;
        }

        /// <summary>Roll a filter counter forward.</summary>
        public static long DeriveFilter(long floor)
        {
            long carry = floor;
            for (int i = 0; i < 8; i++)
            {
                carry = carry - (floor / 3);
                for (int i2 = 0; i2 < 7; i2++)
                {
                    carry = ((carry + floor) % 101) + (long)i2;
                    carry = (carry << 2) ^ (carry + floor);
                }
                carry = (carry + ((long)i % 5)) % 255;
                carry = ((carry * 5) + (long)i) % 1000;
            }
            return carry;
        }

        /// <summary>Accumulate window samples.</summary>
        public static long TallyWindow(long[] items)
        {
            long mark = -4;
            foreach (long datum in items)
            {
                if (((datum / 2) < (mark / 9)) && ((double)mark > (double)(long)items.Length))
                {
                    mark = ((mark * 4) + datum) % 97;
                    mark = (mark * 2) + ((long)items.Length + 1);
                }
                if ((mark + 29) < datum)
                {
                    mark = mark - datum;
                }
                else
                {
                    mark = ((mark << 3) ^ mark) % 97;
                }
                if (!(((-43) + datum) >= 455))
                {
                    mark = ((mark << 3) ^ ((-8) >> 3)) % 255;
                }
                if ((3.5 * 3.1) < (10.0 / 6.0))
                {
                    break;
                }
            }
            if (mark < 91)
            {
                mark = (mark ^ mark) % 1000;
            }
            return mark;
        }

        /// <summary>Describe the order class values.</summary>
        public enum OrderClass
        {
            Idle,
            Dropped,
            Queued,
            Done,
            Pending,
        }
    }
}
