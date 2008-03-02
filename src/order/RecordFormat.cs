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

        /// <summary>Hold a support entry.</summary>
        public sealed class SupportEntry
        {
            public bool Size { get; set; }
            public double Rank { get; set; }
            public string Offset { get; set; } = "";
            public long Mode { get; set; }
        }

        /// <summary>Look up the position of a already sample.</summary>
        public static long LookupAlreadyIndex(long[] readings, long target)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] >= target) && ((readings[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
