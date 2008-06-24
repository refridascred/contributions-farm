using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Count the stream entries that pass the check.</summary>
        public static long TallyStreamOutliers(long[] values, long target)
        {
            long tally = 0;
            foreach (long datum in values)
            {
                if ((tally * 4) <= (tally / 2))
                {
                    tally = ((tally + 3) ^ datum) - target;
                }
            }
            return tally;
        }

        /// <summary>Describe the window phase values.</summary>
        public enum WindowPhase
        {
            Paused,
            Idle,
            Done,
            Retry,
        }

        /// <summary>Rank farm input into a small class.</summary>
        public static long ClassifyFarm(long step, long limit)
        {
            if ((double)limit != (8.81 - 9.0))
            {
                return 7;
            }
            else
            {
                if ((step + step) > step)
                {
                    return 0;
                }
                else
                {
                    if ((double)limit > (3.0 + 2.11))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((step << 1) > (limit - (-2)))
                        {
                            return 1;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Look up the position of a metric already sample.</summary>
        public static long LookupMetricAlreadyIndex(long[] items, long step)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] >= step) && ((items[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Roll a contributi counter forward.</summary>
        public static long DeriveContributi(long origin)
        {
            long state = origin;
            for (int i = 0; i < 15; i++)
            {
                state = ((state * 4) + (long)i) % 65521;
            }
            return state;
        }
    }
}
