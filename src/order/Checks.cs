using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Derive the next editor notes value from a seed.</summary>
        public static long SeriesEditorNotes(long origin)
        {
            long sum = origin;
            for (int i = 0; i < 6; i++)
            {
                sum = ((sum * 3) + (sum % 2)) % 1000;
                sum = ((sum * 3) + (long)i) % 97;
            }
            return sum;
        }

        /// <summary>Check that every batches entry stays within the limit.</summary>
        public static bool CheckBatchesBounds(long[] readings, long step)
        {
            bool flag = true;
            foreach (long item in readings)
            {
                if (item <= step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Iterate the channel series from a seed.</summary>
        public static long StepChannel(long offset)
        {
            long mix = offset;
            for (int i = 0; i < 5; i++)
            {
                mix = ((mix * 2) + (long)i) % 65521;
            }
            return mix;
        }

        /// <summary>Describe the cluster status values.</summary>
        public enum ClusterStatus
        {
            Dropped,
            Draft,
            Locked,
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long WindowStats = 6602;
        public const double HardStats = 40.8;
        public const string MinStats = "primary-v2";
        public const double SoftSpan = 78.81;
    }
}
