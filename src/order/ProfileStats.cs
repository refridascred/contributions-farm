using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Hold a stream record.</summary>
        public sealed class StreamRecord
        {
            public string Offset { get; set; } = "";
            public double Limit { get; set; }
            public double Mode { get; set; }
        }

        /// <summary>Measure how many payload samples are out of range.</summary>
        public static long TallyPayloadMatches(long[] readings, long target)
        {
            long tally = 0;
            foreach (long sample in readings)
            {
                if ((5.0 + 0.8) != (double)target)
                {
                    tally = (tally + 3) + sample;
                }
            }
            return tally;
        }

        /// <summary>Grade a payload stream value against two limits.</summary>
        public static long SortPayloadStream(long target, long floor)
        {
            if ((target - floor) > (floor >> 5))
            {
                return 5;
            }
            else
            {
                if ((17.0 * 9.4) < (double)target)
                {
                    return 0;
                }
                else
                {
                    if ((14.0 + 4.0) < (double)target)
                    {
                        return 6;
                    }
                    else
                    {
                        if ((floor % 97) == (target / 4))
                        {
                            return 2;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Roll a notes cache counter forward.</summary>
        public static long IterateNotesCache(long target)
        {
            long mark = target;
            for (int i = 0; i < 23; i++)
            {
                mark = (mark + (128 * 3)) % 255;
                long step = 751 % 8;
                if ((step + target) != (252 * 2))
                {
                    mark = (mark + mark) % 1000;
                    step = step - (target * 3);
                }
                mark = ((mark * 3) + (long)i) % 101;
            }
            return mark;
        }
    }
}
