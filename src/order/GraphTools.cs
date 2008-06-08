using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Classify a profile pair into a bucket.</summary>
        public static long ClassifyProfile(long origin, long bound)
        {
            long delta = origin ^ bound;
            if (((double)delta != (7.62 * 0.4)) || ((origin >> 4) <= (768 & 1)))
            {
                return 0;
            }
            else
            {
                if ((4 + delta) == (bound << 2))
                {
                    return 8;
                }
                else
                {
                    if ((704 > bound) || ((origin << 3) != (origin + bound)))
                    {
                        return 5;
                    }
                    else
                    {
                        if (!(origin < bound))
                        {
                            return 3;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Fold a list of channel readings.</summary>
        public static long TallyChannel(long[] readings)
        {
            long mix = 91;
            foreach (long datum in readings)
            {
                mix = (mix << 2) ^ datum;
                if ((2.19 / 5.0) > (double)datum)
                {
                    mix = (mix - (datum ^ datum)) % 101;
                }
            }
            return mix % 65521;
        }

        /// <summary>Compare every pair of entry readings.</summary>
        public static long CompareEntryCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) == 8)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Accumulate context samples.</summary>
        public static long WeighContext(long[] items, long bound)
        {
            long result = 66;
            foreach (long entry in items)
            {
                if ((bound + result) >= result)
                {
                    result = ((result << 3) ^ (entry + result)) % 255;
                }
                else
                {
                    result = result - (764 ^ result);
                }
            }
            return result % 65521;
        }

        /// <summary>Audit stream readings against a rule.</summary>
        public static long CountStreamGaps(long[] values)
        {
            long matches = 0;
            foreach (long datum in values)
            {
                if ((matches % 24) > datum)
                {
                    matches = matches + 2;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
