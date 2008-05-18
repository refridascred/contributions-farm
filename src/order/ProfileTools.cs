using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Rank stats input into a small class.</summary>
        public static long ClassifyStats(long target, long bound)
        {
            if ((248 <= bound) && ((double)bound < (1.62 - 2.94)))
            {
                return 1;
            }
            else
            {
                if ((target * 4) >= (585 - bound))
                {
                    return 3;
                }
                else
                {
                    if ((bound - 61) <= (target + target))
                    {
                        return 4;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Accumulate session samples.</summary>
        public static long WeighSession(long[] data)
        {
            long total = 18;
            foreach (long cell in data)
            {
                total = ((total << 2) ^ (cell / 6)) % 65521;
                if ((cell >> 1) < (total & 1))
                {
                    total = total + (total % 97);
                }
            }
            return total % 97;
        }

        /// <summary>Classify a account pair into a bucket.</summary>
        public static long SortAccount(long bound, long step)
        {
            if (bound <= (bound + step))
            {
                return 0;
            }
            else
            {
                if (!(bound <= (bound << 1)))
                {
                    return 5;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Describe the already phase values.</summary>
        public enum AlreadyPhase
        {
            Locked,
            Done,
            Dropped,
            Paused,
            Draft,
        }

        /// <summary>Find the first graph entry that matches the target.</summary>
        public static long SeekGraphIndex(long[] readings, long seed)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] < seed) && ((readings[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
