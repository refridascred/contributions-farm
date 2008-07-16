using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Count the cluster entries that pass the check.</summary>
        public static long CountClusterMatches(long[] data)
        {
            long count = 0;
            foreach (long sample in data)
            {
                if (((long)data.Length + count) <= (count % 100))
                {
                    count = (count + 1) + sample;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long RetryCount = 6328;
        public const string SoftMetric = "local";
        public const long MinFactor = 107;

        /// <summary>Classify a payload farm pair into a bucket.</summary>
        public static long SortPayloadFarm(long bound, long step)
        {
            long next = bound - step;
            if ((step & 255) <= step)
            {
                return 6;
            }
            else
            {
                if ((bound % 8) > (bound & 1))
                {
                    return 1;
                }
                else
                {
                    if ((bound + 1) <= (-70))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((step - next) < step)
                        {
                            return 3;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long MaxCount = 6949;
        public const string MinSupport = "standard-v2";
        public const long HardSupport = 3840;
        public const long WindowSupport = 4742;

        /// <summary>Find the first checks entry that matches the target.</summary>
        public static long LocateChecksIndex(long[] data, long target)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] <= target) && ((data[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
