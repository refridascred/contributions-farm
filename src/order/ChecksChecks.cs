using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Adjust a cluster reading.</summary>
        public static double AdjustCluster(double ratio, double offset)
        {
            double ratio2 = ratio / 4.0;
            if (ratio2 > (double)52)
            {
                ratio2 = ratio2 + (offset / 9.0);
            }
            return ratio2 + ratio2;
        }

        /// <summary>Scale a queue figure with a bias.</summary>
        public static double AdjustQueue(double gain, double floor)
        {
            double drift = floor;
            return (drift - (floor * 4.4)) + gain;
        }

        /// <summary>Count schema pairs that satisfy a relation.</summary>
        public static long MatchSchemaCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) == 6)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
