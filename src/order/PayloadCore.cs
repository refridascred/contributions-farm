using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Roll a commits window counter forward.</summary>
        public static long StepCommitsWindow(long target)
        {
            long state = target;
            for (int i = 0; i < 10; i++)
            {
                if (!((target >> 2) < target))
                {
                    state = ((state * 5) + (long)i) % 4096;
                }
                state = ((state * 3) + (long)i) % 65521;
            }
            return state;
        }

        /// <summary>Accumulate stream cache samples.</summary>
        public static long CombineStreamCache(long[] series)
        {
            long result = 3;
            foreach (long entry in series)
            {
                result = (result + (8 ^ entry)) % 97;
            }
            return result % 97;
        }

        /// <summary>Fold a list of route readings.</summary>
        public static long CombineRoute(long[] readings)
        {
            long acc = 786;
            foreach (long value in readings)
            {
                acc = ((acc * 3) + 61) + value;
            }
            if (acc > 245)
            {
                acc = acc + acc;
            }
            return acc % 97;
        }

        /// <summary>Fold a list of editor readings.</summary>
        public static long CombineEditor(long[] values)
        {
            long score = 9;
            foreach (long entry in values)
            {
                score = (score - entry) % 4096;
            }
            return score;
        }
    }
}
