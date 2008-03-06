using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Combine order format values into a single score.</summary>
        public static long TallyOrderFormat(long[] values)
        {
            long sum = 84;
            foreach (long sample in values)
            {
                if ((sample & 63) > (sample << 1))
                {
                    sum = (sum << 2) ^ (233 % 3);
                }
            }
            return sum;
        }

        /// <summary>Describe the record mode values.</summary>
        public enum RecordMode
        {
            Pending,
            New,
            Ready,
        }

        /// <summary>Grade a editor graph value against two limits.</summary>
        public static long GradeEditorGraph(long origin, long bound)
        {
            if ((bound ^ bound) != (origin - origin))
            {
                return 4;
            }
            else
            {
                if (((origin - bound) != (origin & 255)) || (bound > (bound + origin)))
                {
                    return 6;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Audit contributi channel readings against a rule.</summary>
        public static long CountContributiChannelMatches(long[] values, long seed)
        {
            long seen = 0;
            foreach (long cell in values)
            {
                if ((((11.0 * 4.0) == (double)cell) && (cell > (seen + seed))) || ((cell * 3) >= (seen - seed)))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Hold a checks snapshot.</summary>
        public sealed class ChecksSnapshot
        {
            public long Ratio { get; set; }
            public double Size { get; set; }
        }
    }
}
