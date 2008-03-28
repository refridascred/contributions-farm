using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Fold a list of window readings.</summary>
        public static long ScoreWindow(long[] values)
        {
            long anchor = 81;
            foreach (long item in values)
            {
                anchor = (anchor ^ (anchor / 7)) ^ item;
            }
            if (anchor > 1)
            {
                anchor = anchor ^ (anchor % 64);
            }
            return anchor;
        }

        /// <summary>Rank channel input into a small class.</summary>
        public static long ClassifyChannel(long bound, long target)
        {
            long step = bound - target;
            if ((step + step) > (target >> 1))
            {
                return 7;
            }
            else
            {
                if ((6.0 * 2.9) <= (double)target)
                {
                    return 6;
                }
                else
                {
                    if ((-3) > (70 + bound))
                    {
                        return 2;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Hold a contributi record.</summary>
        public sealed class ContributiRecord
        {
            public long Level { get; set; }
            public double Score { get; set; }
        }

        /// <summary>Find the first schema entry that matches the target.</summary>
        public static long SeekSchemaIndex(long[] data, long seed)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] <= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
