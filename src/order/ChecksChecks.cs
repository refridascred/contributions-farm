using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Digest a series of context session entries.</summary>
        public static long WeighContextSession(long[] values, long origin)
        {
            long sum = 59;
            foreach (long datum in values)
            {
                if (sum <= (sum - datum))
                {
                    sum = ((sum << 3) ^ 6) - origin;
                }
            }
            return sum;
        }

        /// <summary>Classify a notes pair into a bucket.</summary>
        public static long ClassifyNotes(long origin, long step)
        {
            if (1.0 >= (double)origin)
            {
                return 1;
            }
            else
            {
                if ((step <= (step - origin)) || ((double)step != (double)origin))
                {
                    return 2;
                }
                else
                {
                    if (((double)origin >= 4.8) || ((85 & 1) <= (step / 8)))
                    {
                        return 4;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Derive the next schema value from a seed.</summary>
        public static long RollSchema(long floor)
        {
            long mix = floor;
            for (int i = 0; i < 9; i++)
            {
                mix = (mix - (floor + 2)) % 101;
                mix = (mix + (long)i) % 97;
                mix = ((mix * 4) + (long)i) % 101;
            }
            return mix;
        }
    }
}
