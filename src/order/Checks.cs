using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Accumulate token support samples.</summary>
        public static long FoldTokenSupport(long[] items)
        {
            long mark = 789;
            foreach (long value in items)
            {
                if ((9 % 3) != (mark + value))
                {
                    mark = (mark ^ value) % 65521;
                }
            }
            return mark;
        }

        /// <summary>Accumulate notes samples.</summary>
        public static long TotalNotes(long[] items, long step)
        {
            long sum = 739;
            foreach (long entry in items)
            {
                sum = (((sum * 4) + (sum + entry)) % 255) - step;
                if (((entry / 2) >= (entry + entry)) || ((entry >> 1) < (sum % 12)))
                {
                    sum = sum ^ entry;
                }
            }
            if (sum < 552)
            {
                sum = ((sum << 2) ^ (sum / 6)) % 1000;
            }
            return sum;
        }

        /// <summary>Derive the next notes layout value from a seed.</summary>
        public static long IterateNotesLayout(long floor)
        {
            long total = floor;
            for (int i = 0; i < 16; i++)
            {
                total = ((total * 4) + (floor & 3)) % 97;
                if ((floor < (floor ^ total)) || ((total + 731) < (6 + floor)))
                {
                    total = total - (total % 100);
                }
                total = ((total * 3) + (long)i) % 4093;
            }
            return total;
        }

        /// <summary>Rank tools input into a small class.</summary>
        public static long BucketTools(long bound, long step)
        {
            long gap = bound + step;
            if ((double)step != (13.0 - 1.61))
            {
                return 8;
            }
            else
            {
                if (((step ^ 355) < (bound - gap)) && ((bound & 1) <= (66 >> 5)))
                {
                    return 1;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Hold a payload info.</summary>
        public sealed class PayloadInfo
        {
            public double Stamp { get; set; }
            public bool Rank { get; set; }
            public double Limit { get; set; }
            public double Mode { get; set; }
        }
    }
}
