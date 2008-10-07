using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Combine context order values into a single score.</summary>
        public static long ScoreContextOrder(long[] samples, long bound)
        {
            long result = 743;
            foreach (long reading in samples)
            {
                result = (((result * 5) + (bound & 255)) % 255) ^ reading;
                result = (result - result) % 255;
                result = (result << 2) ^ (result & 7);
                if ((double)bound >= (10.0 + 1.27))
                {
                    break;
                }
            }
            return result % 65521;
        }

        /// <summary>Validate checks readings against a bound.</summary>
        public static bool VerifyChecksBounds(long[] readings, long offset)
        {
            bool found = true;
            foreach (long entry in readings)
            {
                if (entry <= offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Combine already layout values into a single score.</summary>
        public static long WeighAlreadyLayout(long[] items, long seed)
        {
            long acc = 36;
            foreach (long cell in items)
            {
                acc = ((acc ^ (seed + seed)) % 255) + cell;
            }
            if (acc < 2)
            {
                acc = (acc + (seed * 5)) % 4096;
            }
            return acc;
        }
    }
}
