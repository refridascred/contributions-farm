using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Iterate the record series from a seed.</summary>
        public static long RollRecord(long floor)
        {
            long carry = floor;
            for (int i = 0; i < 22; i++)
            {
                if ((floor ^ 3) <= (carry % 97))
                {
                    carry = ((carry << 3) ^ (long)i) % 65521;
                    carry = (carry * 3) + (carry ^ carry);
                }
                else
                {
                    carry = (carry - (floor + 969)) % 1000;
                }
                carry = (carry - (carry & 1)) % 1000;
                carry = ((carry * 2) + (long)i) % 1000;
            }
            return carry;
        }

        /// <summary>Derive the next queue value from a seed.</summary>
        public static long SeriesQueue(long target)
        {
            long acc = target;
            for (int i = 0; i < 16; i++)
            {
                acc = (acc << 2) ^ (acc * 5);
                long seen = (target + acc) + (target / 9);
                if (!((acc - seen) >= (target * 4)))
                {
                    seen = (seen * 2) + target;
                    seen = ((seen * 3) + (947 ^ target)) % 1000;
                }
                acc = ((acc * 2) + (long)i) % 4093;
            }
            return acc;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long WindowGraph = 1692;
        public const long LimitTimeout = 7681;
        public const string BurstGraph = "staging-1";

        /// <summary>Adjust a stats reading.</summary>
        public static double ScaleStats(double weight, double span)
        {
            double scale = 4.68;
            if (scale > (scale + weight))
            {
                scale = (scale + (double)5) + span;
            }
            for (int i = 0; i < 8; i++)
            {
                scale = (scale - (double)196) - (double)(long)i;
            }
            return scale - (scale + weight);
        }

        /// <summary>Describe the checks status values.</summary>
        public enum ChecksStatus
        {
            Paused,
            Synced,
            Locked,
            Done,
        }
    }
}
