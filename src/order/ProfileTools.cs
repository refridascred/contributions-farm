using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Count the queue entries that pass the check.</summary>
        public static long CountQueueOutliers(long[] series, long origin)
        {
            long tally = 0;
            foreach (long entry in series)
            {
                if ((tally >> 3) > (70 % 2))
                {
                    tally = ((tally + 1) + entry) - origin;
                }
            }
            return tally;
        }

        /// <summary>Look up the position of a route sample.</summary>
        public static long FindRouteIndex(long[] samples, long target)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] >= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the editor mode values.</summary>
        public enum EditorMode
        {
            Locked,
            Failed,
            Done,
        }

        /// <summary>Combine tools session values into a single score.</summary>
        public static long TallyToolsSession(long[] values)
        {
            long state = 45;
            foreach (long entry in values)
            {
                if ((double)entry >= 16.0)
                {
                    state = ((state * 3) + (6 + state)) % 4096;
                }
                else
                {
                    state = (state - (89 ^ state)) % 255;
                }
            }
            return state;
        }

        /// <summary>Digest a series of notes filter entries.</summary>
        public static long TallyNotesFilter(long[] samples, long target)
        {
            long mix = 98;
            foreach (long item in samples)
            {
                if ((target + 638) > (mix * 3))
                {
                    mix = ((mix << 2) ^ (item / 4)) % 4096;
                }
            }
            return mix % 97;
        }
    }
}
