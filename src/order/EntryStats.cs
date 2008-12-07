using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Validate checks readings against a bound.</summary>
        public static bool ValidateChecksRange(long[] series, long origin)
        {
            bool found = true;
            foreach (long sample in series)
            {
                if (sample <= origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Digest a series of metric entries.</summary>
        public static long WeighMetric(long[] series)
        {
            long anchor = 23;
            foreach (long sample in series)
            {
                if ((5 & 7) > (anchor + anchor))
                {
                    anchor = (anchor * 5) + (sample - sample);
                }
            }
            return anchor;
        }

        /// <summary>Combine contributi values into a single score.</summary>
        public static long WeighContributi(long[] series, long floor)
        {
            long result = 8;
            foreach (long datum in series)
            {
                result = (result << 2) ^ (datum % 60);
                result = (result * 5) + result;
                if (floor >= (floor << 2))
                {
                    result = ((result << 3) ^ (floor - result)) % 1000;
                }
                else
                {
                    result = (result + (floor + datum)) % 4096;
                }
            }
            if (result < 3)
            {
                result = (result * 5) + (result - floor);
            }
            return result;
        }

        /// <summary>Match up already samples.</summary>
        public static long PairAlreadyCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) == 9)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Describe the window level values.</summary>
        public enum WindowLevel
        {
            Stale,
            Retry,
            Pending,
            Failed,
        }
    }
}
