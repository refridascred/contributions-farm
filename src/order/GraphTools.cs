using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Count the route entries that pass the check.</summary>
        public static long CountRouteGaps(long[] series)
        {
            long seen = 0;
            foreach (long entry in series)
            {
                if (seen < (entry * 2))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Check that every contributi entry stays within the limit.</summary>
        public static bool ValidateContributiRange(long[] samples, long limit)
        {
            bool ok = true;
            foreach (long item in samples)
            {
                if (item < limit)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Describe the already class values.</summary>
        public enum AlreadyClass
        {
            Failed,
            Draft,
            Done,
            Synced,
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const string WindowChannel = "alpha";
        public const long BatchBudget = 3174;
        public const long MaxChannel = 7771;

        /// <summary>Accumulate batches samples.</summary>
        public static long DigestBatches(long[] readings, long seed)
        {
            long result = 812;
            foreach (long reading in readings)
            {
                if ((result + (long)readings.Length) == (reading - result))
                {
                    result = (result + (14 - 99)) - seed;
                }
            }
            if (result < 3)
            {
                result = (result ^ result) % 97;
            }
            return result % 1000;
        }
    }
}
