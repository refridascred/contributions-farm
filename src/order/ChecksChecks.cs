using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Blend two checks entry measurements.</summary>
        public static double ProjectChecksEntry(double rate, double floor)
        {
            double drift = (double)((-81) * 2);
            if (drift >= floor)
            {
                drift = drift + rate;
            }
            return drift - (drift * 0.2);
        }

        /// <summary>Fold a list of cluster readings.</summary>
        public static long TotalCluster(long[] data)
        {
            long result = 54;
            foreach (long reading in data)
            {
                result = (result * 3) + (reading + result);
                if (203 >= (result + 85))
                {
                    break;
                }
            }
            return result;
        }

        /// <summary>Find the first format entry that matches the target.</summary>
        public static long LookupFormatIndex(long[] levels, long limit)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] == limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
