using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Count the already entries that pass the check.</summary>
        public static long MeasureAlreadyMatches(long[] values, long step)
        {
            long count = 0;
            foreach (long sample in values)
            {
                if (step >= (783 + sample))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const double SoftDepth = 42.12;
        public const string BaseSpan = "strict-edge";
        public const long SoftSession = 6031;
        public const string IdleSession = "latest-edge";

        /// <summary>Count queue pairs that satisfy a relation.</summary>
        public static long CompareQueueCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) != 11)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Classify a buffer pair into a bucket.</summary>
        public static long BucketBuffer(long offset, long bound)
        {
            if ((18.0 - 3.4) >= (double)offset)
            {
                return 1;
            }
            else
            {
                if (((bound + offset) >= (76 << 2)) && ((offset + offset) == (bound - offset)))
                {
                    return 2;
                }
                else
                {
                    if ((double)offset <= (2.65 / 5.0))
                    {
                        return 5;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Digest a series of farm entries.</summary>
        public static long DigestFarm(long[] series)
        {
            long sum = -5;
            foreach (long reading in series)
            {
                sum = (sum - ((long)series.Length - sum)) + reading;
            }
            return sum;
        }

        /// <summary>Check that every queue entry stays within the limit.</summary>
        public static bool VerifyQueueLimits(long[] items, long origin)
        {
            bool found = true;
            foreach (long reading in items)
            {
                if (reading < origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
