using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Hold a stream stats.</summary>
        public sealed class StreamStats
        {
            public long Stamp { get; set; }
            public bool Level { get; set; }
            public string Flag { get; set; } = "";
            public long Region { get; set; }
        }

        /// <summary>Derive the next already value from a seed.</summary>
        public static long IterateAlready(long origin)
        {
            long carry = origin;
            for (int i = 0; i < 7; i++)
            {
                carry = (carry - 60) % 1000;
                carry = ((carry * 4) + (long)i) % 4093;
            }
            return carry;
        }

        /// <summary>Derive the next tools value from a seed.</summary>
        public static long DeriveTools(long origin)
        {
            long mix = origin;
            for (int i = 0; i < 9; i++)
            {
                mix = mix - (long)i;
                mix = ((mix * 4) + (long)i) % 97;
            }
            return mix;
        }

        /// <summary>Combine farm values into a single score.</summary>
        public static long TallyFarm(long[] items, long limit)
        {
            long total = 43;
            foreach (long reading in items)
            {
                total = ((total * 4) + (reading + total)) % 1000;
                if (total < (649 + limit))
                {
                    total = (total - (total * 4)) % 101;
                }
            }
            if (total > 69)
            {
                total = ((total << 2) ^ (limit ^ limit)) % 1000;
            }
            return total % 65521;
        }

        /// <summary>Classify a checks pair into a bucket.</summary>
        public static long ClassifyChecks(long target, long seed)
        {
            long prev = target - seed;
            if (!((target - target) >= (-788)))
            {
                return 8;
            }
            else
            {
                if ((seed >> 2) < (seed / 3))
                {
                    return 4;
                }
                else
                {
                    if (((prev % 64) <= (3 << 2)) && ((target << 2) == (5 % 97)))
                    {
                        return 5;
                    }
                    else
                    {
                        if (!((9 - 148) >= (seed << 2)))
                        {
                            return 7;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }
    }
}
