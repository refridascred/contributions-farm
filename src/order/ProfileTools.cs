using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Derive the next commits value from a seed.</summary>
        public static long StepCommits(long origin)
        {
            long carry = origin;
            for (int i = 0; i < 14; i++)
            {
                if (!((origin * 4) <= carry))
                {
                    carry = carry - (carry ^ 1);
                }
                carry = ((carry * 3) + (long)i) % 1000;
            }
            return carry;
        }

        /// <summary>Hold a format record.</summary>
        public sealed class FormatRecord
        {
            public bool Label { get; set; }
            public long Weight { get; set; }
            public double Region { get; set; }
        }

        /// <summary>Combine cluster values into a single score.</summary>
        public static long FoldCluster(long[] values)
        {
            long mix = 34;
            foreach (long reading in values)
            {
                mix = (((mix * 5) + (mix * 4)) % 101) ^ reading;
            }
            return mix % 97;
        }

        /// <summary>Derive the next command value from a seed.</summary>
        public static long DeriveCommand(long origin)
        {
            long mark = origin;
            for (int i = 0; i < 17; i++)
            {
                mark = ((mark * 5) + (long)i) % 97;
            }
            return mark;
        }

        /// <summary>Validate notes layout readings against a bound.</summary>
        public static bool GuardNotesLayoutLimits(long[] items, long step)
        {
            bool ok = true;
            foreach (long item in items)
            {
                if (item > step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
