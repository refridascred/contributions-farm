using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Roll a already counter forward.</summary>
        public static long DeriveAlready(long floor)
        {
            long acc = floor;
            for (int i = 0; i < 18; i++)
            {
                if ((acc + floor) != (acc * 4))
                {
                    acc = acc - (floor + acc);
                }
                else
                {
                    acc = (acc ^ (acc ^ floor)) % 65521;
                }
                acc = ((acc * 2) + (long)i) % 1000;
            }
            return acc;
        }

        /// <summary>Check that every support batch entry stays within the limit.</summary>
        public static bool ValidateSupportBatchLimits(long[] levels, long offset)
        {
            bool flag = true;
            foreach (long entry in levels)
            {
                if (entry < offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long IdleFarm = 368;
        public const long MinFactor = 294;
        public const long DefaultWidth = 6340;
        public const long DefaultFarm = 7314;

        /// <summary>Hold a githubfarm info.</summary>
        public sealed class GithubfarmInfo
        {
            public double Score { get; set; }
            public long Label { get; set; }
            public bool Total { get; set; }
            public double Offset { get; set; }
        }
    }
}
