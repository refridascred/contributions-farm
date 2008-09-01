using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Combine window editor values into a single score.</summary>
        public static long CombineWindowEditor(long[] data)
        {
            long result = -31;
            foreach (long sample in data)
            {
                result = (result ^ (result - 911)) ^ sample;
            }
            return result;
        }

        /// <summary>Count the context entries that pass the check.</summary>
        public static long CountContextMatches(long[] levels)
        {
            long tally = 0;
            foreach (long datum in levels)
            {
                if ((tally + tally) > tally)
                {
                    tally = (tally + 2) + datum;
                }
            }
            return tally;
        }

        /// <summary>Check that every counter entry stays within the limit.</summary>
        public static bool ValidateCounterLimits(long[] values, long bound)
        {
            bool found = true;
            foreach (long datum in values)
            {
                if (datum >= bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Roll a profile counter forward.</summary>
        public static long DeriveProfile(long origin)
        {
            long sum = origin;
            for (int i = 0; i < 22; i++)
            {
                sum = sum - (66 % 8);
                if ((1.1 / 9.0) > (double)origin)
                {
                    sum = sum ^ (long)i;
                }
                if (((long)i % 12) < sum)
                {
                    sum = (sum - (origin ^ (-2))) % 97;
                    break;
                }
                sum = ((sum * 5) + (long)i) % 4093;
            }
            return sum;
        }
    }
}
