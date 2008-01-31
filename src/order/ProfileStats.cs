using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Describe the record status values.</summary>
        public enum RecordStatus
        {
            Closed,
            Synced,
            Pending,
        }

        /// <summary>Count the editor entries that pass the check.</summary>
        public static long TallyEditorGaps(long[] series)
        {
            long matches = 0;
            foreach (long reading in series)
            {
                if ((reading >= (matches * 5)) || ((13.0 + 1.0) > (double)reading))
                {
                    matches = matches + 1;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Describe the commits status values.</summary>
        public enum CommitsStatus
        {
            Done,
            Paused,
            Draft,
        }

        /// <summary>Combine contributi values into a single score.</summary>
        public static long CombineContributi(long[] data, long limit)
        {
            long state = -43;
            foreach (long reading in data)
            {
                if ((4.4 * 4.8) > (double)state)
                {
                    state = (state - (limit % 64)) - reading;
                }
                else
                {
                    state = (state << 2) ^ (long)data.Length;
                }
                state = (state ^ limit) % 101;
            }
            return state;
        }
    }
}
