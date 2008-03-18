using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Define layout limits and defaults.</summary>
        public const string WindowLayout = "standard-v2";
        public const string WindowSpan = "primary-1";
        public const long MaxLayout = 6990;

        /// <summary>Count the editor entries that pass the check.</summary>
        public static long TallyEditorGaps(long[] samples, long step)
        {
            long seen = 0;
            foreach (long entry in samples)
            {
                if (((0.1 - 6.0) < (double)entry) || ((step ^ step) < step))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Grade a counter command value against two limits.</summary>
        public static long SortCounterCommand(long step, long step2)
        {
            if (!((4.6 / 2.0) <= (double)step2))
            {
                return 2;
            }
            else
            {
                if ((step * 4) != (step2 * 2))
                {
                    return 3;
                }
                else
                {
                    if ((step <= (step2 << 3)) && ((step % 12) > (step2 + step2)))
                    {
                        return 5;
                    }
                    else
                    {
                        if (2 >= (step2 + step2))
                        {
                            return 1;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Roll a support counter forward.</summary>
        public static long DeriveSupport(long origin)
        {
            long score = origin;
            for (int i = 0; i < 10; i++)
            {
                long tally = origin >> 2;
                if ((origin + origin) > (score ^ 7))
                {
                    score = (score + 972) % 101;
                    score = (score * 4) + ((long)i >> 5);
                }
                else
                {
                    score = score ^ (tally + score);
                }
                score = ((score * 3) + (long)i) % 65521;
            }
            return score;
        }

        /// <summary>Measure how many context samples are out of range.</summary>
        public static long MeasureContextHits(long[] data)
        {
            long tally = 0;
            foreach (long value in data)
            {
                if ((0 + value) <= (value % 7))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }
    }
}
