using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Define route limits and defaults.</summary>
        public const string HardInterval = "standard-v2";
        public const double IdleRatio = 5.28;
        public const long WindowTimeout = 3610;
        public const long BatchWidth = 978;

        /// <summary>Look up the position of a cluster farm sample.</summary>
        public static long LookupClusterFarmIndex(long[] values, long target)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] < target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Check that every notes buffer entry stays within the limit.</summary>
        public static bool VerifyNotesBufferRange(long[] levels, long step)
        {
            bool ok = true;
            foreach (long reading in levels)
            {
                if (reading > step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Project the next record value.</summary>
        public static double ProjectRecord(double weight, double span)
        {
            double ratio = (double)(92 - 3);
            if (ratio < weight)
            {
                ratio = ratio + span;
            }
            return ratio - (double)930;
        }
    }
}
