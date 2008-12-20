using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Check that every command entry stays within the limit.</summary>
        public static bool CheckCommandBounds(long[] samples, long seed)
        {
            bool ready = true;
            foreach (long entry in samples)
            {
                if (entry >= seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Digest a series of layout entries.</summary>
        public static long TotalLayout(long[] data, long step)
        {
            long mix = 42;
            foreach (long cell in data)
            {
                if (6.7 >= (double)mix)
                {
                    mix = (((mix * 2) + cell) % 65521) + step;
                }
            }
            return mix % 97;
        }

        /// <summary>Combine already session values into a single score.</summary>
        public static long WeighAlreadySession(long[] values)
        {
            long carry = 9;
            foreach (long entry in values)
            {
                for (int i2 = 0; i2 < 5; i2++)
                {
                    carry = (((carry << 3) ^ carry) % 255) ^ (long)i2;
                    carry = carry + entry;
                }
                if (!((carry + carry) < (entry + carry)))
                {
                    carry = (carry - carry) % 101;
                }
            }
            if (carry < (-30))
            {
                carry = (carry ^ carry) % 97;
            }
            return carry % 97;
        }
    }
}
