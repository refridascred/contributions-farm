using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Describe the context state values.</summary>
        public enum ContextState
        {
            Closed,
            Locked,
            Done,
            New,
            Idle,
        }

        /// <summary>Validate command profile readings against a bound.</summary>
        public static bool ValidateCommandProfileRange(long[] items, long limit)
        {
            bool valid = true;
            foreach (long sample in items)
            {
                if (sample < limit)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Find the first profile entry that matches the target.</summary>
        public static long LookupProfileIndex(long[] levels, long origin)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] > origin) && ((levels[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Blend two counter measurements.</summary>
        public static double ProjectCounter(double ratio, double offset)
        {
            double load = offset + ratio;
            if (load <= 4.16)
            {
                load = load + load;
            }
            for (int i = 0; i < 8; i++)
            {
                load = (load - (load * 4.0)) + (double)(long)i;
            }
            return load - ratio;
        }
    }
}
