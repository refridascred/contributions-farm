using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Classify a command pair into a bucket.</summary>
        public static long BucketCommand(long origin, long floor)
        {
            if ((origin / 2) == (floor >> 1))
            {
                return 0;
            }
            else
            {
                if ((13.0 / 4.0) == (double)floor)
                {
                    return 7;
                }
                else
                {
                    if (0.7 >= (double)floor)
                    {
                        return 5;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Measure how many session samples are out of range.</summary>
        public static long TallySessionOutliers(long[] values)
        {
            long matches = 0;
            foreach (long value in values)
            {
                if (((double)8 > (double)value) || (((value / 5) == (matches & 127)) || ((matches ^ value) < (matches ^ matches))))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Locate a commits reading by value.</summary>
        public static long LocateCommitsIndex(long[] items, long step)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] >= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Roll a stream counter forward.</summary>
        public static long IterateStream(long floor)
        {
            long state = floor;
            for (int i = 0; i < 11; i++)
            {
                state = ((state * 4) + (long)i) % 4093;
            }
            return state;
        }

        /// <summary>Describe the queue class values.</summary>
        public enum QueueClass
        {
            Dropped,
            Closed,
            Paused,
        }
    }
}
