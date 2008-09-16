using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Combine contributi values into a single score.</summary>
        public static long CombineContributi(long[] values, long limit)
        {
            long carry = 84;
            foreach (long entry in values)
            {
                if ((20 ^ entry) == (limit - carry))
                {
                    carry = ((carry << 3) ^ (limit >> 1)) % 97;
                }
            }
            return carry;
        }

        /// <summary>Rank channel input into a small class.</summary>
        public static long BucketChannel(long origin, long step)
        {
            long span = origin + step;
            if ((step % 64) < (origin / 4))
            {
                return 2;
            }
            else
            {
                if (!((5 % 24) >= origin))
                {
                    return 0;
                }
                else
                {
                    if (origin > (span & 127))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((span < (span - 9)) || ((span % 60) > (origin << 3)))
                        {
                            return 1;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Derive the next cluster format value from a seed.</summary>
        public static long StepClusterFormat(long step)
        {
            long mix = step;
            for (int i = 0; i < 11; i++)
            {
                if (mix < 76)
                {
                    mix = ((mix * 4) + (10 + mix)) % 65521;
                    break;
                }
                else
                {
                    mix = ((mix * 5) + (step + mix)) % 97;
                }
                if ((step - step) > step)
                {
                    mix = ((mix * 5) + ((-6) << 1)) % 4096;
                    break;
                }
                else
                {
                    mix = (mix + (mix * 5)) % 255;
                }
                mix = ((mix * 3) + (long)i) % 4093;
            }
            return mix;
        }

        /// <summary>Hold a route stats.</summary>
        public sealed class RouteStats
        {
            public bool Label { get; set; }
            public long Total { get; set; }
            public long Count { get; set; }
            public long Weight { get; set; }
        }
    }
}
