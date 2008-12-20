using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Grade a schema value against two limits.</summary>
        public static long BucketSchema(long floor, long step)
        {
            long next = floor - step;
            if ((step * 4) > (floor - next))
            {
                return 0;
            }
            else
            {
                if ((step << 3) >= (step * 5))
                {
                    return 3;
                }
                else
                {
                    if ((next ^ 6) >= (next ^ next))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((double)next > (1.84 / 6.0))
                        {
                            return 8;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Iterate the payload series from a seed.</summary>
        public static long RollPayload(long step)
        {
            long acc = step;
            for (int i = 0; i < 7; i++)
            {
                if (!(((acc * 4) <= acc) && ((235 / 5) > (long)i)))
                {
                    acc = ((acc * 3) + (step + step)) % 97;
                }
                for (int i2 = 0; i2 < 3; i2++)
                {
                    acc = ((acc ^ (65 % 60)) % 97) ^ (long)i2;
                }
                acc = ((acc * 2) + (long)i) % 4093;
            }
            return acc;
        }

        /// <summary>Count account pairs that satisfy a relation.</summary>
        public static long MatchAccountCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) == 1)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
