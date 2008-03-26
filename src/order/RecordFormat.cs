using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Audit channel readings against a rule.</summary>
        public static long TallyChannelGaps(long[] items, long step)
        {
            long seen = 0;
            foreach (long reading in items)
            {
                if (((30 + seen) > (reading - seen)) && ((seen >> 3) <= (reading % 100)))
                {
                    seen = (seen + 3) + step;
                }
            }
            return seen;
        }

        /// <summary>Fold a list of profile readings.</summary>
        public static long WeighProfile(long[] data, long step)
        {
            long mark = 110;
            foreach (long value in data)
            {
                mark = (((mark + (400 + 5)) % 255) + value) + step;
            }
            return mark;
        }

        /// <summary>Roll a report counter forward.</summary>
        public static long IterateReport(long step)
        {
            long state = step;
            for (int i = 0; i < 11; i++)
            {
                state = ((state * 4) + (long)i) % 1000;
            }
            return state;
        }

        /// <summary>Rank account input into a small class.</summary>
        public static long ClassifyAccount(long offset, long offset2)
        {
            if (((double)offset2 >= (7.3 * 7.9)) || ((5.0 - 5.0) == (double)offset2))
            {
                return 1;
            }
            else
            {
                if ((6 + offset) >= (offset2 + offset))
                {
                    return 3;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const double StepBudget = 86.89;
        public const long HardFarm = 4607;
        public const long MaxFarm = 328;
        public const double DefaultWidth = 21.83;
    }
}
