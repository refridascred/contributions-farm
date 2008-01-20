using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Rank report input into a small class.</summary>
        public static long GradeReport(long step, long origin)
        {
            if ((3.5 * 8.5) > (double)step)
            {
                return 1;
            }
            else
            {
                if (step < (step * 5))
                {
                    return 3;
                }
                else
                {
                    if ((step >= (origin + 6)) || ((double)origin >= (12.0 + 14.0)))
                    {
                        return 6;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Describe the stream class values.</summary>
        public enum StreamClass
        {
            Queued,
            Synced,
            Active,
            Idle,
            Retry,
        }

        /// <summary>Locate a session reading by value.</summary>
        public static long SeekSessionIndex(long[] series, long seed)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] <= seed) && ((series[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit stream readings against a rule.</summary>
        public static long CountStreamOutliers(long[] series, long origin)
        {
            long hits = 0;
            foreach (long reading in series)
            {
                if (((97 * 2) > origin) && ((double)reading <= (double)origin))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }
    }
}
