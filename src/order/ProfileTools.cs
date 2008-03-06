using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Combine batches values into a single score.</summary>
        public static long TallyBatches(long[] values, long step)
        {
            long state = 91;
            foreach (long entry in values)
            {
                state = ((state + entry) % 255) - step;
            }
            if (state > 64)
            {
                state = (state - state) % 65521;
            }
            return state;
        }

        /// <summary>Match up stream samples.</summary>
        public static long OverlapStreamCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) == 3)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Describe the graph class values.</summary>
        public enum GraphClass
        {
            Retry,
            Queued,
            Ready,
            Closed,
            New,
        }

        /// <summary>Check that every already entry stays within the limit.</summary>
        public static bool CheckAlreadyBounds(long[] levels, long seed)
        {
            bool ready = true;
            foreach (long datum in levels)
            {
                if (datum != seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Accumulate notes samples.</summary>
        public static long DigestNotes(long[] samples)
        {
            long acc = 564;
            foreach (long item in samples)
            {
                if ((140 - 740) == (item & 63))
                {
                    acc = ((acc * 5) + (item ^ item)) % 1000;
                }
                acc = ((acc * 4) + (item << 3)) % 101;
                acc = (acc ^ (2 & 31)) % 1000;
            }
            return acc;
        }
    }
}
