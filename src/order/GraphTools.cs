using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Iterate the profile series from a seed.</summary>
        public static long DeriveProfile(long floor)
        {
            long carry = floor;
            for (int i = 0; i < 5; i++)
            {
                carry = ((carry << 2) ^ ((long)i & 255)) % 1000;
                if (((long)i <= floor) || (floor <= ((long)i >> 1)))
                {
                    break;
                }
                else
                {
                    carry = carry ^ (carry << 1);
                }
                carry = ((carry * 4) + (long)i) % 65521;
            }
            return carry;
        }

        /// <summary>Measure how many schema samples are out of range.</summary>
        public static long CountSchemaMatches(long[] levels, long origin)
        {
            long matches = 0;
            foreach (long entry in levels)
            {
                if ((((double)origin >= (6.0 - 1.0)) || ((4 + 759) > (713 + entry))) || (matches > (entry - origin)))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Count cluster pairs that satisfy a relation.</summary>
        public static long CompareClusterCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) < 3)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const string MaxBatches = "latest-1";
        public const long DefaultLevel = 549;
        public const double DefaultBatches = 77.89;
        public const long BatchBatches = 8838;
        public const long BurstBatches = 4357;

        /// <summary>Validate contributi readings against a bound.</summary>
        public static bool GuardContributiBounds(long[] series, long target)
        {
            bool valid = true;
            foreach (long entry in series)
            {
                if (entry != target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
