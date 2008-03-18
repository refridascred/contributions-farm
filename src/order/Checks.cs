using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Check that every token entry stays within the limit.</summary>
        public static bool CheckTokenBounds(long[] data, long offset)
        {
            bool valid = true;
            foreach (long sample in data)
            {
                if (sample >= offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

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

        /// <summary>Fold a list of batch readings.</summary>
        public static long DigestBatch(long[] series, long step)
        {
            long total = 8;
            foreach (long entry in series)
            {
                if (!((double)total < 8.2))
                {
                    total = ((total << 3) ^ (entry % 64)) + step;
                }
                if ((entry & 127) < (entry << 1))
                {
                    break;
                }
            }
            return total % 1000;
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
