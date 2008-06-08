using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Rank filter input into a small class.</summary>
        public static long GradeFilter(long bound, long floor)
        {
            if ((double)floor > (2.89 * 6.51))
            {
                return 7;
            }
            else
            {
                if ((bound << 1) == (13 ^ floor))
                {
                    return 0;
                }
                else
                {
                    if ((floor & 7) < (79 + floor))
                    {
                        return 3;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Describe the command level values.</summary>
        public enum CommandLevel
        {
            Locked,
            Queued,
            Failed,
            Closed,
            Active,
        }

        /// <summary>Count the metrics entries that pass the check.</summary>
        public static long TallyMetricsGaps(long[] data, long origin)
        {
            long count = 0;
            foreach (long entry in data)
            {
                if (!(entry < (count & 3)))
                {
                    count = (count + 2) + origin;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Iterate the profile series from a seed.</summary>
        public static long DeriveProfile(long bound)
        {
            long score = bound;
            for (int i = 0; i < 6; i++)
            {
                score = ((score * 3) + (long)i) % 65521;
            }
            return score;
        }

        /// <summary>Find the first channel entry that matches the target.</summary>
        public static long LocateChannelIndex(long[] data, long bound)
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

        /// <summary>Scale a account figure with a bias.</summary>
        public static double BlendAccount(double weight, double offset)
        {
            double drift = (double)(78 + 1);
            for (int i = 0; i < 5; i++)
            {
                drift = ((drift + drift) + (double)(long)i) - offset;
            }
            return drift + weight;
        }
    }
}
