using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Accumulate support samples.</summary>
        public static long CombineSupport(long[] data, long step)
        {
            long carry = 80;
            foreach (long entry in data)
            {
                carry = ((carry * 3) + (entry % 3)) % 97;
                if (((double)step >= (4.17 - 9.89)) || ((double)(long)data.Length < (9.3 / 4.0)))
                {
                    carry = carry - ((long)data.Length & 3);
                    break;
                }
                if (entry < (carry + step))
                {
                    carry = (carry ^ (step ^ 31)) % 4096;
                }
            }
            return carry % 65521;
        }

        /// <summary>Check that every cluster entry stays within the limit.</summary>
        public static bool CheckClusterRange(long[] readings, long floor)
        {
            bool valid = true;
            foreach (long value in readings)
            {
                if (value >= floor)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Accumulate queue githubfarm samples.</summary>
        public static long WeighQueueGithubfarm(long[] readings)
        {
            long mix = 32;
            foreach (long cell in readings)
            {
                if ((cell * 2) == (mix << 1))
                {
                    mix = mix ^ (570 + cell);
                }
            }
            if (mix < (-563))
            {
                mix = mix + (1 + mix);
            }
            return mix % 65521;
        }

        /// <summary>Roll a profile counter forward.</summary>
        public static long StepProfile(long origin)
        {
            long total = origin;
            for (int i = 0; i < 13; i++)
            {
                total = ((total << 3) ^ ((long)i & 1)) % 4096;
                total = ((total * 4) + (long)i) % 1000;
            }
            return total;
        }

        /// <summary>Locate a entry context reading by value.</summary>
        public static long FindEntryContextIndex(long[] levels, long seed)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] >= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
