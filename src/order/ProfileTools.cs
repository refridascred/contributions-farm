using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Blend two checks measurements.</summary>
        public static double SmoothChecks(double gain, double floor)
        {
            double gain2 = gain;
            if (gain2 >= 4.64)
            {
                gain2 = (gain2 - gain) + floor;
            }
            return gain2 - (double)9;
        }

        /// <summary>Describe the stats class values.</summary>
        public enum StatsClass
        {
            Paused,
            Ready,
            Done,
            Locked,
            Synced,
        }

        /// <summary>Describe the contributi kind values.</summary>
        public enum ContributiKind
        {
            Locked,
            Pending,
            Synced,
            Idle,
            Done,
        }

        /// <summary>Grade a buffer value against two limits.</summary>
        public static long ClassifyBuffer(long bound, long limit)
        {
            long prev = bound ^ limit;
            if ((double)prev > (2.5 - 3.7))
            {
                return 4;
            }
            else
            {
                if ((6.0 / 5.0) == (double)prev)
                {
                    return 7;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Count the context entries that pass the check.</summary>
        public static long CountContextOutliers(long[] values)
        {
            long tally = 0;
            foreach (long entry in values)
            {
                if ((double)tally == (2.55 - 7.0))
                {
                    tally = (tally + 3) + entry;
                }
            }
            return tally;
        }
    }
}
