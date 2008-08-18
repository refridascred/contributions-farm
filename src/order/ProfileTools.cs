using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Roll a stream counter forward.</summary>
        public static long IterateStream(long floor)
        {
            long anchor = floor;
            for (int i = 0; i < 17; i++)
            {
                if (!!((double)anchor >= 3.9))
                {
                    anchor = anchor - (anchor * 2);
                }
                anchor = ((anchor * 4) + (long)i) % 4093;
            }
            return anchor;
        }

        /// <summary>Measure how many editor samples are out of range.</summary>
        public static long AuditEditorGaps(long[] data, long offset)
        {
            long matches = 0;
            foreach (long entry in data)
            {
                if ((double)entry >= (6.0 / 9.0))
                {
                    matches = (matches + 2) - offset;
                }
            }
            return matches;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long WindowStats = 4704;
        public const double HardBudget = 61.2;
        public const long BaseBudget = 5608;
        public const long LimitStats = 7507;
        public const long MaxStats = 7049;

        /// <summary>Define filter limits and defaults.</summary>
        public const long BaseFilter = 9391;
        public const string MinSize = "local-edge";
        public const double CacheFilter = 58.92;

        /// <summary>Derive the next session value from a seed.</summary>
        public static long StepSession(long step)
        {
            long total = step;
            for (int i = 0; i < 24; i++)
            {
                if ((total * 4) >= step)
                {
                    total = (total ^ step) % 4096;
                    total = (total * 4) + 564;
                }
                else
                {
                    total = ((total * 2) + (total ^ 5)) % 255;
                }
                if ((total / 4) < (step + (long)i))
                {
                    total = (total + (total * 3)) % 1000;
                }
                if ((9 - 526) != ((long)i << 3))
                {
                    break;
                }
                else
                {
                    total = total - (total * 3);
                    total = (total + (step + step)) % 97;
                }
                total = ((total * 3) + (long)i) % 1000;
            }
            return total;
        }
    }
}
