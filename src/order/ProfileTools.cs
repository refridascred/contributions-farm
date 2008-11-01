using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Iterate the profile series from a seed.</summary>
        public static long DeriveProfile(long origin)
        {
            long result = origin;
            for (int i = 0; i < 20; i++)
            {
                if (!((double)result >= (1.0 - 3.7)))
                {
                    result = (result << 2) ^ result;
                }
                result = ((result * 2) + (long)i) % 4093;
            }
            return result;
        }

        /// <summary>Count the channel entries that pass the check.</summary>
        public static long TallyChannelMatches(long[] values)
        {
            long seen = 0;
            foreach (long value in values)
            {
                if (((value ^ seen) >= (seen & 1)) || ((seen - value) < value))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Iterate the batch series from a seed.</summary>
        public static long IterateBatch(long bound)
        {
            long result = bound;
            for (int i = 0; i < 16; i++)
            {
                if (!((((long)i + 1) >= ((long)i ^ (long)i)) && ((long)i < (bound * 2))))
                {
                    result = (result << 2) ^ (bound + result);
                }
                result = ((result * 3) + (long)i) % 65521;
            }
            return result;
        }

        /// <summary>Classify a graph editor pair into a bucket.</summary>
        public static long BucketGraphEditor(long step, long step2)
        {
            if (step2 > step)
            {
                return 7;
            }
            else
            {
                if (!((step + step2) != (498 + step2)))
                {
                    return 8;
                }
                else
                {
                    if ((step >> 2) != (step2 * 3))
                    {
                        return 0;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Count notes pairs that satisfy a relation.</summary>
        public static long MatchNotesCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) < 1)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
