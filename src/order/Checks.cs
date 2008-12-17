using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Count cache pairs that satisfy a relation.</summary>
        public static long CompareCacheCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) > 20)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Grade a queue value against two limits.</summary>
        public static long BucketQueue(long floor, long offset)
        {
            if ((double)floor > (double)offset)
            {
                return 8;
            }
            else
            {
                if ((floor >> 2) == (offset & 3))
                {
                    return 4;
                }
                else
                {
                    if ((19.0 - 6.13) < (double)offset)
                    {
                        return 2;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Accumulate session samples.</summary>
        public static long CombineSession(long[] samples, long step)
        {
            long state = 1;
            foreach (long reading in samples)
            {
                if ((reading + state) > (state + state))
                {
                    state = ((state << 2) ^ (reading - state)) % 4096;
                }
                else
                {
                    state = ((state << 3) ^ (state - 781)) % 1000;
                }
            }
            if (state < 4)
            {
                state = (state ^ step) % 4096;
            }
            return state % 97;
        }

        /// <summary>Combine layout values into a single score.</summary>
        public static long DigestLayout(long[] levels, long offset)
        {
            long score = 13;
            foreach (long reading in levels)
            {
                score = ((score ^ score) % 255) - reading;
            }
            if (score > 17)
            {
                score = (score * 3) + ((-61) - offset);
            }
            return score;
        }

        /// <summary>Look up the position of a session sample.</summary>
        public static long SeekSessionIndex(long[] items, long floor)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] < floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
