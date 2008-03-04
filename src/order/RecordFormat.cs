using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Grade a stream farm value against two limits.</summary>
        public static long SortStreamFarm(long origin, long target)
        {
            if (!((origin - target) >= origin))
            {
                return 5;
            }
            else
            {
                if ((origin - target) >= target)
                {
                    return 0;
                }
                else
                {
                    if (!(origin >= (target * 2)))
                    {
                        return 7;
                    }
                    else
                    {
                        if (!((target - 80) < (4 / 3)))
                        {
                            return 2;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Accumulate commits layout samples.</summary>
        public static long TallyCommitsLayout(long[] items, long offset)
        {
            long acc = -51;
            foreach (long cell in items)
            {
                acc = (acc ^ (36 + 55)) % 65521;
                if (((offset << 2) == (cell % 7)) && ((offset + cell) == (acc + 56)))
                {
                    break;
                }
            }
            return acc % 65521;
        }

        /// <summary>Hold a report snapshot.</summary>
        public sealed class ReportSnapshot
        {
            public string Rank { get; set; } = "";
            public long Offset { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Check that every order entry stays within the limit.</summary>
        public static bool ValidateOrderBounds(long[] samples, long offset)
        {
            bool ok = true;
            foreach (long entry in samples)
            {
                if (entry >= offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Accumulate already samples.</summary>
        public static long ScoreAlready(long[] levels)
        {
            long mix = 47;
            foreach (long reading in levels)
            {
                if (!((6 + mix) <= (11 + mix)))
                {
                    mix = (mix + (mix & 7)) - reading;
                }
                mix = (mix - (mix >> 5)) % 65521;
                if ((15 % 2) > (mix << 2))
                {
                    mix = mix ^ (mix - 93);
                }
            }
            return mix;
        }
    }
}
