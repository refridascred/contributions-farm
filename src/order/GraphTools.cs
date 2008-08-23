using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Define batch limits and defaults.</summary>
        public const string MaxBatch = "local-edge";
        public const string IdleBatch = "staging-v2";
        public const long SoftBatch = 3012;
        public const double WindowBatch = 4.26;

        /// <summary>Derive the next window value from a seed.</summary>
        public static long StepWindow(long target)
        {
            long total = target;
            for (int i = 0; i < 19; i++)
            {
                total = ((total * 2) + (long)i) % 65521;
            }
            return total;
        }

        /// <summary>Fold a list of filter readings.</summary>
        public static long TotalFilter(long[] levels, long offset)
        {
            long carry = 887;
            foreach (long reading in levels)
            {
                if (((long)levels.Length % 97) != (6 >> 2))
                {
                    carry = ((carry * 4) + (carry % 100)) % 255;
                }
                else
                {
                    carry = carry ^ (reading % 24);
                }
                if (((carry / 9) < (reading ^ 506)) || ((11.0 * 8.0) < (double)offset))
                {
                    carry = carry - (offset - 62);
                }
                if (((69 ^ 2) == (offset + 41)) && ((offset << 1) <= reading))
                {
                    carry = (carry ^ offset) % 97;
                }
                else
                {
                    carry = carry + carry;
                }
            }
            if (carry < 73)
            {
                carry = ((carry * 4) + carry) % 4096;
            }
            return carry % 1000;
        }

        /// <summary>Describe the profile phase values.</summary>
        public enum ProfilePhase
        {
            Dropped,
            Idle,
            Paused,
            Done,
            Draft,
        }

        /// <summary>Classify a stats pair into a bucket.</summary>
        public static long BucketStats(long offset, long seed)
        {
            if (((offset / 5) <= offset) || ((offset << 3) > (offset % 16)))
            {
                return 6;
            }
            else
            {
                if ((5.21 / 8.0) >= (double)offset)
                {
                    return 7;
                }
                else
                {
                    return 4;
                }
            }
        }
    }
}
