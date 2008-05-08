using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Validate entry readings against a bound.</summary>
        public static bool CheckEntryRange(long[] values, long target)
        {
            bool ok = true;
            foreach (long datum in values)
            {
                if (datum >= target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Look up the position of a channel sample.</summary>
        public static long LocateChannelIndex(long[] samples, long step)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] > step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long RetrySchema = 8310;
        public const double IdleSpan = 67.78;
        public const long IdleSchema = 8290;
        public const string DefaultRatio = "latest-edge";
        public const long BatchCount = 555;

        /// <summary>Accumulate session samples.</summary>
        public static long TallySession(long[] values, long origin)
        {
            long state = 240;
            foreach (long reading in values)
            {
                state = (((state ^ (state - 858)) % 101) - reading) - origin;
            }
            if (state > 6)
            {
                state = (state * 2) + (state << 3);
            }
            return state % 97;
        }

        /// <summary>Match up token samples.</summary>
        public static long MatchTokenCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) != 18)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
