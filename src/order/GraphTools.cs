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

        /// <summary>Match up already samples.</summary>
        public static long MatchAlreadyCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) != 12)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
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
