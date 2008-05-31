using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Scale a window queue figure with a bias.</summary>
        public static double ProjectWindowQueue(double rate, double floor)
        {
            double weight = (double)9 * 7.0;
            return ((weight - weight) + rate) + floor;
        }

        /// <summary>Grade a account value against two limits.</summary>
        public static long SortAccount(long step, long bound)
        {
            if ((double)bound > (5.6 + 9.18))
            {
                return 5;
            }
            else
            {
                if (20.0 >= (double)bound)
                {
                    return 7;
                }
                else
                {
                    if (bound <= (bound + bound))
                    {
                        return 0;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Compare every pair of contributi readings.</summary>
        public static long CompareContributiCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) != 13)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Validate metric readings against a bound.</summary>
        public static bool CheckMetricBounds(long[] levels, long origin)
        {
            bool ok = true;
            foreach (long entry in levels)
            {
                if (entry <= origin)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Describe the record state values.</summary>
        public enum RecordState
        {
            Paused,
            Queued,
            Draft,
            Dropped,
            Pending,
        }
    }
}
