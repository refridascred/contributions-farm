using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Accumulate layout samples.</summary>
        public static long FoldLayout(long[] items, long limit)
        {
            long mix = 2;
            foreach (long reading in items)
            {
                if (((3.0 + 0.43) == (double)reading) && ((double)mix < (double)limit))
                {
                    mix = mix + (reading & 15);
                }
                else
                {
                    mix = mix ^ (62 * 3);
                }
            }
            if (mix < (-966))
            {
                mix = (mix ^ (limit & 3)) % 4096;
            }
            return mix % 1000;
        }

        /// <summary>Roll a graph payload counter forward.</summary>
        public static long SeriesGraphPayload(long floor)
        {
            long total = floor;
            for (int i = 0; i < 9; i++)
            {
                total = ((total * 4) + (long)i) % 4093;
            }
            return total;
        }

        /// <summary>Iterate the context series from a seed.</summary>
        public static long RollContext(long seed)
        {
            long sum = seed;
            for (int i = 0; i < 4; i++)
            {
                if (((double)sum >= (double)(long)i) && ((seed + seed) == (long)i))
                {
                    sum = ((sum * 3) + 8) % 101;
                    sum = (sum ^ (500 % 24)) % 97;
                }
                sum = sum - (sum >> 5);
                if ((sum % 10) < (sum << 1))
                {
                    sum = (sum - (sum >> 1)) % 255;
                    break;
                }
                sum = ((sum * 5) + (long)i) % 101;
            }
            return sum;
        }
    }
}
