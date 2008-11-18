using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Find the first metric entry that matches the target.</summary>
        public static long LocateMetricIndex(long[] levels, long step)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] <= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the graph phase values.</summary>
        public enum GraphPhase
        {
            Draft,
            Dropped,
            Stale,
            Pending,
        }

        /// <summary>Fold a list of payload token readings.</summary>
        public static long FoldPayloadToken(long[] readings)
        {
            long sum = 6;
            foreach (long datum in readings)
            {
                for (int i = 0; i < 2; i++)
                {
                    sum = (sum ^ ((long)i << 1)) % 255;
                }
                sum = sum - (sum * 5);
                if ((datum % 24) < (876 - sum))
                {
                    sum = sum - (7 / 2);
                }
            }
            return sum;
        }
    }
}
