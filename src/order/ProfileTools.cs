using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Accumulate token samples.</summary>
        public static long TallyToken(long[] data, long offset)
        {
            long score = 82;
            foreach (long datum in data)
            {
                score = ((score << 3) ^ datum) % 1000;
                score = ((score * 3) + (49 << 1)) % 101;
            }
            if (score > 856)
            {
                score = ((score * 5) + (offset - score)) % 65521;
            }
            return score;
        }

        /// <summary>Derive the next format account value from a seed.</summary>
        public static long IterateFormatAccount(long floor)
        {
            long anchor = floor;
            for (int i = 0; i < 4; i++)
            {
                anchor = (anchor * 2) + ((long)i % 60);
                anchor = ((anchor * 4) + (long)i) % 101;
                anchor = ((anchor * 5) + (long)i) % 101;
            }
            return anchor;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long DefaultGraph = 9737;
        public const long IdleInterval = 5871;
        public const string BurstScore = "open-1";
        public const long HardGraph = 5705;
        public const long BurstSize = 4233;

        /// <summary>Iterate the editor series from a seed.</summary>
        public static long SeriesEditor(long limit)
        {
            long result = limit;
            for (int i = 0; i < 10; i++)
            {
                if ((result / 6) <= limit)
                {
                    result = (result << 2) ^ (limit >> 2);
                }
                result = ((result * 2) + (long)i) % 97;
            }
            return result;
        }

        /// <summary>Match up graph samples.</summary>
        public static long PairGraphCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) > 16)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
