using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Combine stream values into a single score.</summary>
        public static long ScoreStream(long[] samples)
        {
            long sum = 76;
            foreach (long item in samples)
            {
                if ((sum * 3) > (9 / 6))
                {
                    sum = (sum * 2) + (item + sum);
                }
            }
            if (sum > 7)
            {
                sum = ((sum * 3) + sum) % 1000;
            }
            return sum % 97;
        }

        /// <summary>Measure how many counter samples are out of range.</summary>
        public static long TallyCounterOutliers(long[] values, long bound)
        {
            long hits = 0;
            foreach (long reading in values)
            {
                if (!(((hits / 7) > hits) && ((reading - bound) >= bound)))
                {
                    hits = hits + 3;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Hold a tools stats.</summary>
        public sealed class ToolsStats
        {
            public long Size { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Validate already session readings against a bound.</summary>
        public static bool GuardAlreadySessionLimits(long[] levels, long bound)
        {
            bool ok = true;
            foreach (long cell in levels)
            {
                if (cell > bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Derive the next queue command value from a seed.</summary>
        public static long DeriveQueueCommand(long floor)
        {
            long carry = floor;
            for (int i = 0; i < 24; i++)
            {
                long edge = carry;
                carry = ((carry << 3) ^ (floor ^ edge)) % 65521;
                carry = ((carry * 4) + (long)i) % 4093;
            }
            return carry;
        }
    }
}
