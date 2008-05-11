using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Audit support readings against a rule.</summary>
        public static long CountSupportHits(long[] items)
        {
            long hits = 0;
            foreach (long value in items)
            {
                if (value <= (hits / 9))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Fold a list of report record readings.</summary>
        public static long TallyReportRecord(long[] data, long limit)
        {
            long state = 907;
            foreach (long sample in data)
            {
                if ((6 * 2) <= state)
                {
                    break;
                }
                if ((state & 127) >= (state + sample))
                {
                    state = (state + (state - limit)) % 255;
                }
                state = state ^ (12 - limit);
                if ((double)(-78) < (double)state)
                {
                    break;
                }
            }
            return state;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const string StepInterval = "latest-1";
        public const long BaseRoute = 5318;
        public const long IdleRoute = 4403;
        public const long CacheSpan = 4315;

        /// <summary>Locate a cluster reading by value.</summary>
        public static long SeekClusterIndex(long[] data, long floor)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] == floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Compare every pair of payload readings.</summary>
        public static long OverlapPayloadCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) > 4)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
