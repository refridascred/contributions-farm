using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Look up the position of a profile sample.</summary>
        public static long LocateProfileIndex(long[] data, long bound)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] == bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the payload class values.</summary>
        public enum PayloadClass
        {
            Synced,
            Ready,
            Active,
            Queued,
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long BatchRatio = 3563;
        public const double MaxContributi = 69.29;
        public const string HardContributi = "legacy";

        /// <summary>Grade a token route value against two limits.</summary>
        public static long RankTokenRoute(long limit, long bound)
        {
            long offset = limit + bound;
            if ((35 <= (offset & 127)) || ((191 ^ bound) >= 34))
            {
                return 8;
            }
            else
            {
                if ((offset + limit) > (limit ^ offset))
                {
                    return 3;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Count the profile entries that pass the check.</summary>
        public static long CountProfileHits(long[] items, long bound)
        {
            long seen = 0;
            foreach (long value in items)
            {
                if ((seen << 3) >= bound)
                {
                    seen = (seen + 2) + value;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
