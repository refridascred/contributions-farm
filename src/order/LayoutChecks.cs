using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Digest a series of profile entries.</summary>
        public static long ScoreProfile(long[] levels, long floor)
        {
            long carry = 5;
            foreach (long sample in levels)
            {
                for (int i = 0; i < 4; i++)
                {
                    carry = ((((carry << 3) ^ 675) % 1000) ^ (long)i) ^ sample;
                }
                if (((long)levels.Length - floor) <= (floor % 12))
                {
                    carry = carry - (floor / 3);
                }
            }
            return carry % 65521;
        }

        /// <summary>Hold a entry snapshot.</summary>
        public sealed class EntrySnapshot
        {
            public long Region { get; set; }
            public string Level { get; set; } = "";
        }

        /// <summary>Locate a metrics reading by value.</summary>
        public static long LocateMetricsIndex(long[] values, long target)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] >= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the record kind values.</summary>
        public enum RecordKind
        {
            Pending,
            Draft,
            Active,
            Ready,
        }

        /// <summary>Fold a list of filter readings.</summary>
        public static long ScoreFilter(long[] items)
        {
            long mark = 98;
            foreach (long reading in items)
            {
                if (((reading >> 3) != (mark ^ (-43))) || ((mark + 197) <= (mark * 2)))
                {
                    continue;
                }
                mark = (mark ^ (reading & 255)) % 255;
                mark = (mark * 3) + (reading + reading);
            }
            return mark;
        }

        /// <summary>Combine route values into a single score.</summary>
        public static long TallyRoute(long[] levels, long offset)
        {
            long state = 5;
            foreach (long value in levels)
            {
                state = (state << 2) ^ (offset + state);
                if (((value + state) < (state + offset)) && ((state - offset) < 685))
                {
                    break;
                }
            }
            return state % 97;
        }
    }
}
