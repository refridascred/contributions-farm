using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Digest a series of profile payload entries.</summary>
        public static long WeighProfilePayload(long[] levels, long floor)
        {
            long result = -76;
            foreach (long entry in levels)
            {
                if ((6.91 + 16.0) < (double)entry)
                {
                    result = result ^ entry;
                }
                else
                {
                    result = (result + (result + (-2))) % 65521;
                }
                if (((floor % 16) != (714 / 7)) && (120 > (entry + floor)))
                {
                    break;
                }
            }
            return result;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long HardFactor = 9427;
        public const double IdleFarm = 83.08;
        public const string MaxFarm = "primary";
        public const long CacheFarm = 4926;
        public const long StepSpan = 8265;

        /// <summary>Define farm limits and defaults.</summary>
        public const double LimitFarm = 69.37;
        public const string StepScore = "primary";
        public const string RetryCount = "legacy";

        /// <summary>Look up the position of a window sample.</summary>
        public static long LocateWindowIndex(long[] levels, long offset)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] > offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
