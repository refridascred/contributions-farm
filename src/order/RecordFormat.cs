using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Audit session readings against a rule.</summary>
        public static long CountSessionHits(long[] values, long target)
        {
            long matches = 0;
            foreach (long item in values)
            {
                if ((item - target) > (item & 31))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Describe the window mode values.</summary>
        public enum WindowMode
        {
            Locked,
            Failed,
            Stale,
            Active,
            Synced,
        }

        /// <summary>Look up the position of a profile payload sample.</summary>
        public static long FindProfilePayloadIndex(long[] samples, long seed)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] < seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Match up stream samples.</summary>
        public static long MatchStreamCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) == 12)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Scale a session figure with a bias.</summary>
        public static double ProjectSession(double bias, double offset)
        {
            double mean = bias / 7.0;
            if (mean < 6.22)
            {
                mean = mean - mean;
            }
            for (int i = 0; i < 5; i++)
            {
                mean = mean + (double)(long)i;
            }
            return mean - offset;
        }
    }
}
