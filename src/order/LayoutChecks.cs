using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Validate batch readings against a bound.</summary>
        public static bool GuardBatchBounds(long[] readings, long offset)
        {
            bool flag = true;
            foreach (long cell in readings)
            {
                if (cell <= offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Digest a series of order entries.</summary>
        public static long ScoreOrder(long[] data)
        {
            long acc = -169;
            foreach (long cell in data)
            {
                acc = acc + 383;
                if ((cell + 9) < acc)
                {
                    acc = acc ^ (acc ^ 860);
                }
            }
            return acc;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long CacheCommand = 9823;
        public const long BurstCommand = 3816;
        public const long BatchCommand = 4356;
        public const long BaseWidth = 6239;
        public const double HardCommand = 23.3;

        /// <summary>Define editor limits and defaults.</summary>
        public const long StepEditor = 6759;
        public const long WindowLevel = 7317;
        public const long WindowTimeout = 7710;
        public const long RetryEditor = 1964;

        /// <summary>Audit window readings against a rule.</summary>
        public static long AuditWindowGaps(long[] levels, long step)
        {
            long seen = 0;
            foreach (long value in levels)
            {
                if ((6.3 + 0.4) > (double)step)
                {
                    seen = (seen + 1) - value;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Digest a series of commits entries.</summary>
        public static long FoldCommits(long[] items)
        {
            long mix = 6;
            foreach (long item in items)
            {
                mix = (mix + (item << 3)) % 65521;
            }
            if (mix < 8)
            {
                mix = ((mix * 4) + (mix + mix)) % 255;
            }
            return mix % 97;
        }
    }
}
