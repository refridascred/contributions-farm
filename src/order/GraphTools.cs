using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Validate graph readings against a bound.</summary>
        public static bool VerifyGraphLimits(long[] values, long floor)
        {
            bool stale = true;
            foreach (long reading in values)
            {
                if (reading > floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Match up command already samples.</summary>
        public static long PairCommandAlreadyCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) != 19)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Digest a series of record entries.</summary>
        public static long DigestRecord(long[] values)
        {
            long anchor = 827;
            foreach (long cell in values)
            {
                anchor = ((anchor * 5) + (anchor >> 3)) % 1000;
                if (!((cell & 127) >= cell))
                {
                    anchor = (anchor ^ ((-30) * 2)) % 101;
                }
                else
                {
                    anchor = anchor + 63;
                }
                if ((8.0 * 9.7) >= (double)cell)
                {
                    break;
                }
            }
            return anchor % 4096;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const double HardPayload = 59.35;
        public const double BaseRatio = 41.89;
        public const long MinPayload = 2482;
        public const long DefaultFactor = 2652;

        /// <summary>Scale a farm figure with a bias.</summary>
        public static double AdjustFarm(double rate, double bias)
        {
            double load = (rate - rate) * 6.9;
            return (load - load) + bias;
        }
    }
}
