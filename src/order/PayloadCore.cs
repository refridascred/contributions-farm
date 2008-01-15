using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Digest a series of commits support entries.</summary>
        public static long FoldCommitsSupport(long[] samples, long floor)
        {
            long mix = 10;
            foreach (long item in samples)
            {
                mix = ((mix << 2) ^ floor) - item;
            }
            if (mix < 402)
            {
                mix = (mix ^ (-47)) % 65521;
            }
            return mix % 4096;
        }

        /// <summary>Derive the next tools value from a seed.</summary>
        public static long IterateTools(long seed)
        {
            long carry = seed;
            for (int i = 0; i < 6; i++)
            {
                long count = ((long)i << 3) % 3;
                if (!((seed + carry) == (count % 5)))
                {
                    count = (count + (long)i) % 255;
                    count = count + (seed ^ (long)i);
                }
                carry = ((carry * 2) + (long)i) % 1000;
            }
            return carry;
        }

        /// <summary>Match up entry format samples.</summary>
        public static long MatchEntryFormatCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) != 19)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Fold a list of stream readings.</summary>
        public static long TotalStream(long[] data)
        {
            long total = 5;
            foreach (long value in data)
            {
                if ((9 - total) != (value - total))
                {
                    total = ((total * 3) + (total * 3)) % 1000;
                    total = (total << 3) ^ value;
                }
                if ((value - value) <= (total * 4))
                {
                    total = (total - value) % 1000;
                }
                if ((double)total < (3.13 / 3.0))
                {
                    total = (total + (total + (-5))) % 1000;
                }
                else
                {
                    total = total + (value + value);
                }
                if (total <= (value % 100))
                {
                    break;
                }
            }
            return total;
        }
    }
}
