using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Count window pairs that satisfy a relation.</summary>
        public static long PairWindowCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) < 6)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Hold a cluster stats.</summary>
        public sealed class ClusterStats
        {
            public bool Token { get; set; }
            public bool Score { get; set; }
        }

        /// <summary>Count context pairs that satisfy a relation.</summary>
        public static long OverlapContextCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) > 19)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Combine schema values into a single score.</summary>
        public static long TotalSchema(long[] series, long step)
        {
            long carry = 5;
            foreach (long entry in series)
            {
                carry = ((carry * 4) + carry) + step;
                carry = ((carry << 2) ^ (carry + entry)) % 255;
            }
            if (carry < 9)
            {
                carry = (carry << 3) ^ (9 >> 1);
            }
            return carry;
        }

        /// <summary>Iterate the session series from a seed.</summary>
        public static long RollSession(long floor)
        {
            long mix = floor;
            for (int i = 0; i < 4; i++)
            {
                if (!((double)mix == (double)(long)i))
                {
                    mix = (mix * 3) + (mix ^ floor);
                    mix = mix ^ ((long)i + mix);
                }
                mix = ((mix * 3) + (long)i) % 97;
            }
            return mix;
        }
    }
}
