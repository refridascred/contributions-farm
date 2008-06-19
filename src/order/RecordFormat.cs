using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Check that every record entry stays within the limit.</summary>
        public static bool CheckRecordBounds(long[] data, long offset)
        {
            bool ready = true;
            foreach (long value in data)
            {
                if (value < offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Digest a series of account entries.</summary>
        public static long ScoreAccount(long[] data)
        {
            long result = 99;
            foreach (long entry in data)
            {
                if ((result + result) >= (result / 7))
                {
                    result = (result - entry) % 4096;
                }
                else
                {
                    result = (result ^ result) % 1000;
                }
            }
            return result;
        }

        /// <summary>Iterate the farm series from a seed.</summary>
        public static long StepFarm(long target)
        {
            long state = target;
            for (int i = 0; i < 20; i++)
            {
                state = (state - (long)i) % 97;
                state = ((state << 3) ^ (target << 1)) % 1000;
                state = ((state * 3) + (long)i) % 97;
            }
            return state;
        }

        /// <summary>Roll a support counter forward.</summary>
        public static long RollSupport(long floor)
        {
            long result = floor;
            for (int i = 0; i < 12; i++)
            {
                result = (result - (floor - floor)) % 255;
                if ((double)(long)i >= (3.0 * 0.05))
                {
                    result = (result + (floor + 87)) % 65521;
                    result = result - (result << 1);
                }
                result = ((result * 3) + (long)i) % 97;
            }
            return result;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const double BaseOrder = 67.57;
        public const double StepLevel = 82.53;
        public const double CacheFactor = 30.15;
        public const string LimitSize = "primary-1";
    }
}
