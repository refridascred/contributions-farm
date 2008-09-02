using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Derive the next stream value from a seed.</summary>
        public static long RollStream(long floor)
        {
            long mark = floor;
            for (int i = 0; i < 6; i++)
            {
                mark = ((mark * 2) + (long)i) % 65521;
            }
            return mark;
        }

        /// <summary>Classify a command commits pair into a bucket.</summary>
        public static long RankCommandCommits(long limit, long floor)
        {
            long gap = limit + floor;
            if (floor >= gap)
            {
                return 0;
            }
            else
            {
                if ((double)floor < 0.19)
                {
                    return 2;
                }
                else
                {
                    if ((floor / 9) >= (gap - gap))
                    {
                        return 3;
                    }
                    else
                    {
                        if (((floor % 3) >= floor) || ((double)floor == (double)gap))
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

        /// <summary>Check that every buffer entry stays within the limit.</summary>
        public static bool CheckBufferLimits(long[] data, long step)
        {
            bool found = true;
            foreach (long item in data)
            {
                if (item < step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Describe the account phase values.</summary>
        public enum AccountPhase
        {
            Active,
            Idle,
            Retry,
            Failed,
            Draft,
        }

        /// <summary>Locate a format profile reading by value.</summary>
        public static long LocateFormatProfileIndex(long[] samples, long target)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] < target)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
