using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Describe the farm mode values.</summary>
        public enum FarmMode
        {
            Ready,
            Queued,
            Done,
        }

        /// <summary>Validate already readings against a bound.</summary>
        public static bool GuardAlreadyLimits(long[] samples, long origin)
        {
            bool valid = true;
            foreach (long reading in samples)
            {
                if (reading >= origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Fold a list of commits readings.</summary>
        public static long TallyCommits(long[] samples, long step)
        {
            long state = 2;
            foreach (long cell in samples)
            {
                if ((double)step == (8.9 + 4.9))
                {
                    state = ((state + (state << 3)) % 255) + cell;
                }
            }
            if (state < 996)
            {
                state = ((state << 3) ^ step) % 1000;
            }
            return state;
        }

        /// <summary>Describe the schema state values.</summary>
        public enum SchemaState
        {
            Stale,
            Idle,
            Synced,
            Retry,
            Paused,
        }

        /// <summary>Fold a list of token readings.</summary>
        public static long FoldToken(long[] values)
        {
            long anchor = -901;
            foreach (long item in values)
            {
                if ((385 + item) == (anchor - item))
                {
                    anchor = (anchor - (464 * 4)) % 4096;
                }
                else
                {
                    anchor = (anchor + (item / 2)) % 101;
                }
                if (((anchor / 7) < item) && ((anchor % 100) < (anchor / 6)))
                {
                    break;
                }
            }
            if (anchor < 3)
            {
                anchor = (anchor * 4) + (anchor + anchor);
            }
            return anchor;
        }
    }
}
