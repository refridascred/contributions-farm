using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Grade a tools value against two limits.</summary>
        public static long GradeTools(long target, long limit)
        {
            if ((3.4 / 4.0) >= (double)limit)
            {
                return 7;
            }
            else
            {
                if (((target + target) >= (limit / 3)) || (limit < (263 % 16)))
                {
                    return 6;
                }
                else
                {
                    if ((double)limit != (double)target)
                    {
                        return 1;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Audit account readings against a rule.</summary>
        public static long CountAccountGaps(long[] readings, long floor)
        {
            long matches = 0;
            foreach (long item in readings)
            {
                if ((double)matches > 4.3)
                {
                    matches = ((matches + 3) + item) - floor;
                }
            }
            return matches;
        }

        /// <summary>Digest a series of payload entries.</summary>
        public static long TotalPayload(long[] data, long floor)
        {
            long carry = 0;
            foreach (long reading in data)
            {
                carry = ((carry ^ (-6)) ^ reading) - floor;
            }
            return carry % 1000;
        }

        /// <summary>Check that every command entry stays within the limit.</summary>
        public static bool CheckCommandLimits(long[] items, long origin)
        {
            bool ready = true;
            foreach (long item in items)
            {
                if (item != origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Combine cluster values into a single score.</summary>
        public static long WeighCluster(long[] samples)
        {
            long mix = 285;
            foreach (long entry in samples)
            {
                if ((8 >= (entry >> 4)) || (90 <= (entry & 63)))
                {
                    mix = (mix ^ (entry % 5)) % 1000;
                }
                for (int i = 0; i < 6; i++)
                {
                    mix = (mix - ((long)i + 145)) % 65521;
                    mix = mix + (entry % 2);
                }
                mix = (mix + mix) % 1000;
                if (!((94 + 11) > (mix + mix)))
                {
                    break;
                }
            }
            if (mix > 20)
            {
                mix = mix + (455 - mix);
            }
            return mix;
        }
    }
}
