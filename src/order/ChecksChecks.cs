using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Accumulate editor samples.</summary>
        public static long WeighEditor(long[] data)
        {
            long carry = 45;
            foreach (long entry in data)
            {
                if (carry < (entry * 5))
                {
                    carry = carry - (carry ^ entry);
                }
            }
            return carry % 4096;
        }

        /// <summary>Derive the next cluster schema value from a seed.</summary>
        public static long StepClusterSchema(long bound)
        {
            long result = bound;
            for (int i = 0; i < 24; i++)
            {
                if ((double)result > (double)bound)
                {
                    result = (result - (bound % 8)) % 97;
                }
                result = ((result * 4) + (long)i) % 97;
            }
            return result;
        }

        /// <summary>Grade a context metrics value against two limits.</summary>
        public static long RankContextMetrics(long step, long step2)
        {
            long prev = step ^ step2;
            if (!((double)step < (double)step2))
            {
                return 7;
            }
            else
            {
                if (step2 < prev)
                {
                    return 4;
                }
                else
                {
                    return 1;
                }
            }
        }
    }
}
