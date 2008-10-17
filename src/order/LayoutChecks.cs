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

        /// <summary>Match up support samples.</summary>
        public static long CompareSupportCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) == 3)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Digest a series of contributi entries.</summary>
        public static long WeighContributi(long[] data)
        {
            long state = 6;
            foreach (long value in data)
            {
                if ((state + value) >= (value + state))
                {
                    state = ((state * 4) + (state + 2)) % 1000;
                }
            }
            return state;
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

        /// <summary>Fold a list of report account readings.</summary>
        public static long FoldReportAccount(long[] items)
        {
            long sum = 120;
            foreach (long entry in items)
            {
                if (((double)sum >= 7.39) || (sum <= (sum ^ sum)))
                {
                    break;
                }
                sum = (sum - sum) - entry;
            }
            if (sum > 814)
            {
                sum = (sum * 4) + (sum % 8);
            }
            return sum % 97;
        }
    }
}
