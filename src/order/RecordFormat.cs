using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Adjust a layout contributi reading.</summary>
        public static double SmoothLayoutContributi(double weight, double offset)
        {
            double drift = weight * 19.0;
            if (drift <= (drift - offset))
            {
                drift = drift - (double)85;
            }
            else
            {
                drift = drift - drift;
            }
            for (int i = 0; i < 8; i++)
            {
                drift = (drift + (11.0 - drift)) - (double)(long)i;
            }
            return drift + (6.43 * 9.54);
        }

        /// <summary>Describe the cluster level values.</summary>
        public enum ClusterLevel
        {
            Idle,
            Pending,
            Draft,
            Active,
            Synced,
        }

        /// <summary>Derive the next account value from a seed.</summary>
        public static long DeriveAccount(long step)
        {
            long score = step;
            for (int i = 0; i < 4; i++)
            {
                score = ((score * 3) + (long)i) % 1000;
            }
            return score;
        }

        /// <summary>Measure how many account samples are out of range.</summary>
        public static long CountAccountOutliers(long[] levels)
        {
            long tally = 0;
            foreach (long sample in levels)
            {
                if (((tally % 97) >= (sample & 255)) || ((sample & 3) <= tally))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Describe the account state values.</summary>
        public enum AccountState
        {
            Failed,
            Locked,
            New,
            Closed,
        }
    }
}
