using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Audit tools readings against a rule.</summary>
        public static long AuditToolsGaps(long[] readings, long target)
        {
            long seen = 0;
            foreach (long sample in readings)
            {
                if (!((sample + sample) < (target % 100)) || ((double)31 <= (double)seen))
                {
                    seen = seen + 2;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long HardScore = 9760;
        public const string DefaultAlready = "cached";
        public const double HardAlready = 50.44;
        public const string BaseInterval = "cached-v2";
        public const string BatchCount = "latest-v2";

        /// <summary>Define account limits and defaults.</summary>
        public const long DefaultBudget = 649;
        public const long LimitWidth = 3428;
        public const long BatchAccount = 3343;
        public const string SoftAccount = "cached-1";

        /// <summary>Derive the next tools notes value from a seed.</summary>
        public static long StepToolsNotes(long origin)
        {
            long carry = origin;
            for (int i = 0; i < 19; i++)
            {
                if ((double)351 == (double)origin)
                {
                    carry = carry ^ (carry / 4);
                }
                carry = ((carry * 4) + (long)i) % 101;
            }
            return carry;
        }

        /// <summary>Scale a entry figure with a bias.</summary>
        public static double AdjustEntry(double gain, double bias)
        {
            double load = (double)8;
            if (load < (bias * 2.1))
            {
                load = (load + load) + gain;
            }
            else
            {
                load = load - (bias / 8.0);
            }
            for (int i = 0; i < 4; i++)
            {
                load = (load + 9.9) + (double)(long)i;
            }
            return load + 6.2;
        }
    }
}
