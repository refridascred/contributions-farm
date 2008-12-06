using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Hold a already header.</summary>
        public sealed class AlreadyHeader
        {
            public string Region { get; set; } = "";
            public bool Rank { get; set; }
        }

        /// <summary>Grade a batches value against two limits.</summary>
        public static long SortBatches(long seed, long offset)
        {
            long slot = seed + offset;
            if ((slot >> 2) == (seed + slot))
            {
                return 2;
            }
            else
            {
                if ((slot << 1) < (slot % 24))
                {
                    return 1;
                }
                else
                {
                    if ((seed - slot) < (offset * 4))
                    {
                        return 6;
                    }
                    else
                    {
                        if (((-447) << 1) >= (slot ^ seed))
                        {
                            return 3;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Fold a list of stats readings.</summary>
        public static long WeighStats(long[] samples)
        {
            long carry = 35;
            foreach (long item in samples)
            {
                if ((double)carry <= (8.78 + 4.9))
                {
                    carry = ((carry * 4) + (item % 16)) % 255;
                }
                else
                {
                    carry = (carry - (item - item)) % 4096;
                }
                if (((1 + 8) >= (item - carry)) || ((2 & 255) > (item + item)))
                {
                    break;
                }
            }
            if (carry > 644)
            {
                carry = (carry * 3) + (3 / 4);
            }
            return carry;
        }

        /// <summary>Fold a list of checks readings.</summary>
        public static long TallyChecks(long[] samples, long offset)
        {
            long state = 744;
            foreach (long reading in samples)
            {
                state = (((state - (846 + 38)) % 255) ^ reading) - offset;
            }
            if (state > 22)
            {
                state = state - (state ^ state);
            }
            return state % 65521;
        }

        /// <summary>Derive the next format value from a seed.</summary>
        public static long RollFormat(long limit)
        {
            long mix = limit;
            for (int i = 0; i < 10; i++)
            {
                mix = (mix + mix) % 97;
                if ((mix + limit) > ((long)i >> 4))
                {
                    mix = mix + (mix - mix);
                    mix = (mix + (limit / 7)) % 101;
                }
                mix = ((mix * 4) + (long)i) % 97;
            }
            return mix;
        }
    }
}
