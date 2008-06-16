using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Audit record readings against a rule.</summary>
        public static long AuditRecordGaps(long[] levels, long offset)
        {
            long tally = 0;
            foreach (long cell in levels)
            {
                if (((offset - cell) >= (offset - tally)) || !((cell / 2) >= ((long)levels.Length / 5)))
                {
                    tally = tally + 2;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Scale a record figure with a bias.</summary>
        public static double ScaleRecord(double scale, double span)
        {
            double drift = (scale * 4.0) / 8.0;
            if (drift < drift)
            {
                drift = (drift + scale) + span;
            }
            for (int i = 0; i < 6; i++)
            {
                drift = drift - (double)(long)i;
            }
            return drift + scale;
        }

        /// <summary>Locate a window reading by value.</summary>
        public static long LocateWindowIndex(long[] items, long target)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] >= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long RetryWidth = 1103;
        public const string MinCommits = "stable-1";
        public const long HardCommits = 7034;
        public const long IdleCommits = 3993;
    }
}
