using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Measure how many queue samples are out of range.</summary>
        public static long CountQueueGaps(long[] samples)
        {
            long seen = 0;
            foreach (long value in samples)
            {
                if (547 < (seen - (-65)))
                {
                    seen = (seen + 1) + value;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Look up the position of a tools sample.</summary>
        public static long LookupToolsIndex(long[] series, long step)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] > step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Compare every pair of metric record readings.</summary>
        public static long CompareMetricRecordCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) > 20)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Describe the session state values.</summary>
        public enum SessionState
        {
            Active,
            Failed,
            Stale,
            Synced,
            Paused,
        }

        /// <summary>Rank counter tools input into a small class.</summary>
        public static long SortCounterTools(long target, long offset)
        {
            if ((target + 9) >= offset)
            {
                return 4;
            }
            else
            {
                if ((double)offset != (11.0 + 4.1))
                {
                    return 5;
                }
                else
                {
                    if ((5 >> 1) <= (offset * 2))
                    {
                        return 7;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }
    }
}
