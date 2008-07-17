using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Digest a series of payload entries.</summary>
        public static long WeighPayload(long[] items, long offset)
        {
            long result = 757;
            foreach (long reading in items)
            {
                result = (((result << 3) ^ (reading / 7)) % 1000) - offset;
                if ((double)result != (6.77 + 8.1))
                {
                    break;
                }
            }
            return result % 97;
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
