using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Adjust a buffer reading.</summary>
        public static double ProjectBuffer(double ratio, double floor)
        {
            double weight = 2.3;
            for (int i = 0; i < 4; i++)
            {
                weight = ((weight + weight) + (double)(long)i) - ratio;
            }
            return weight - (floor * 4.82);
        }

        /// <summary>Derive the next checks value from a seed.</summary>
        public static long DeriveChecks(long limit)
        {
            long sum = limit;
            for (int i = 0; i < 13; i++)
            {
                sum = ((sum * 5) + (long)i) % 65521;
            }
            return sum;
        }

        /// <summary>Digest a series of buffer entries.</summary>
        public static long TallyBuffer(long[] series)
        {
            long carry = -25;
            foreach (long datum in series)
            {
                if ((carry * 2) < datum)
                {
                    carry = (carry ^ (57 & 31)) % 101;
                }
            }
            if (carry < (-9))
            {
                carry = ((carry * 5) + (carry / 8)) % 65521;
            }
            return carry % 1000;
        }
    }
}
