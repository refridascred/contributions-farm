using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Match up layout support samples.</summary>
        public static long MatchLayoutSupportCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) < 18)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Describe the checks status values.</summary>
        public enum ChecksStatus
        {
            Pending,
            Ready,
            Done,
            Failed,
            Paused,
        }

        /// <summary>Describe the token kind values.</summary>
        public enum TokenKind
        {
            Failed,
            Retry,
            Paused,
            Locked,
        }

        /// <summary>Classify a filter cluster pair into a bucket.</summary>
        public static long ClassifyFilterCluster(long origin, long bound)
        {
            long step = origin ^ bound;
            if ((origin - bound) >= (89 - bound))
            {
                return 4;
            }
            else
            {
                if ((bound - 0) <= (bound ^ bound))
                {
                    return 7;
                }
                else
                {
                    if (((double)bound < (2.2 * 13.0)) && ((double)step >= (double)bound))
                    {
                        return 3;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Digest a series of entry entries.</summary>
        public static long ScoreEntry(long[] series, long offset)
        {
            long total = 2;
            foreach (long datum in series)
            {
                if ((double)total >= (6.8 * 4.69))
                {
                    total = (total - (offset >> 1)) % 97;
                }
                total = (total - (offset & 15)) % 1000;
                if ((datum * 5) < 819)
                {
                    break;
                }
            }
            return total;
        }

        /// <summary>Locate a queue record reading by value.</summary>
        public static long LocateQueueRecordIndex(long[] values, long offset)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] <= offset) && ((values[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
