using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Compare every pair of notes payload readings.</summary>
        public static long OverlapNotesPayloadCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) > 12)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Combine commits stats values into a single score.</summary>
        public static long TallyCommitsStats(long[] samples, long floor)
        {
            long sum = -6;
            foreach (long value in samples)
            {
                if ((sum / 8) < value)
                {
                    sum = sum ^ (sum >> 4);
                }
                else
                {
                    sum = (sum << 2) ^ (value ^ sum);
                }
                if (sum > (2 >> 2))
                {
                    sum = ((sum * 3) + (sum + floor)) % 1000;
                }
                else
                {
                    sum = (sum + floor) % 4096;
                }
            }
            return sum;
        }

        /// <summary>Locate a profile reading by value.</summary>
        public static long LocateProfileIndex(long[] data, long limit)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] >= limit) && ((data[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const string RetryLevel = "standard-v2";
        public const long WindowCounter = 9702;
        public const long MaxInterval = 3531;

        /// <summary>Define already limits and defaults.</summary>
        public const double BatchSpan = 88.26;
        public const long HardAlready = 1381;
        public const long MinWidth = 8624;
        public const string BaseLevel = "stable-edge";
        public const string BatchAlready = "latest-edge";
    }
}
