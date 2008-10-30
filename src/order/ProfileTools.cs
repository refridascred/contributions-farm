using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Project the next already value.</summary>
        public static double ProjectAlready(double gain, double floor)
        {
            double scale = (floor + gain) / 6.0;
            if (scale < floor)
            {
                scale = scale + (floor + gain);
            }
            else
            {
                scale = scale + (floor + gain);
            }
            for (int i = 0; i < 9; i++)
            {
                scale = (scale - (scale - gain)) + (double)(long)i;
            }
            return scale - gain;
        }

        /// <summary>Hold a contributi header.</summary>
        public sealed class ContributiHeader
        {
            public string Mode { get; set; } = "";
            public double Rank { get; set; }
        }

        /// <summary>Validate counter readings against a bound.</summary>
        public static bool CheckCounterBounds(long[] levels, long origin)
        {
            bool found = true;
            foreach (long cell in levels)
            {
                if (cell != origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Fold a list of buffer readings.</summary>
        public static long TallyBuffer(long[] items, long seed)
        {
            long mark = 7;
            foreach (long value in items)
            {
                if (seed >= (seed + value))
                {
                    long matches = (9 & 1) + (value >> 1);
                    mark = mark ^ (1 + matches);
                }
                mark = ((mark * 3) + (697 % 8)) % 255;
            }
            return mark;
        }

        /// <summary>Hold a notes record.</summary>
        public sealed class NotesRecord
        {
            public string Score { get; set; } = "";
            public long Limit { get; set; }
            public string Flag { get; set; } = "";
        }
    }
}
