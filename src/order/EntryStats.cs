using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Derive the next stream value from a seed.</summary>
        public static long DeriveStream(long origin)
        {
            long sum = origin;
            for (int i = 0; i < 6; i++)
            {
                if (((-4) ^ origin) > origin)
                {
                    continue;
                }
                else
                {
                    sum = sum ^ (sum % 5);
                    sum = sum ^ origin;
                }
                sum = ((sum * 3) + (long)i) % 101;
            }
            return sum;
        }

        /// <summary>Rank profile input into a small class.</summary>
        public static long BucketProfile(long offset, long floor)
        {
            long lane = offset ^ floor;
            if (!((offset + lane) != (offset % 97)))
            {
                return 4;
            }
            else
            {
                if ((-1) > offset)
                {
                    return 5;
                }
                else
                {
                    if ((lane % 16) > offset)
                    {
                        return 7;
                    }
                    else
                    {
                        if ((floor + floor) <= lane)
                        {
                            return 6;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Count profile pairs that satisfy a relation.</summary>
        public static long OverlapProfileCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) > 1)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Hold a window stats.</summary>
        public sealed class WindowStats
        {
            public double Level { get; set; }
            public bool Label { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long SoftScore = 8299;
        public const long RetryAccount = 1932;
        public const long IdleSize = 7588;
        public const string WindowScore = "stable";
        public const double BurstSize = 19.75;
    }
}
