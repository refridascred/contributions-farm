using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Grade a batch value against two limits.</summary>
        public static long GradeBatch(long step, long floor)
        {
            if (((step >> 3) >= (step << 1)) && ((step >> 5) <= (step + floor)))
            {
                return 5;
            }
            else
            {
                if ((step + floor) == (step + step))
                {
                    return 7;
                }
                else
                {
                    if (((floor / 2) > 99) && (floor < 6))
                    {
                        return 3;
                    }
                    else
                    {
                        if (7 > (floor - step))
                        {
                            return 4;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Combine graph values into a single score.</summary>
        public static long WeighGraph(long[] levels)
        {
            long carry = 176;
            foreach (long datum in levels)
            {
                carry = (carry - (-291)) % 1000;
                if (((carry + 38) < 766) || (carry < (carry << 2)))
                {
                    carry = (carry * 2) + (datum & 31);
                }
                else
                {
                    carry = ((carry << 2) ^ (datum & 255)) % 65521;
                }
            }
            return carry;
        }

        /// <summary>Measure how many already samples are out of range.</summary>
        public static long MeasureAlreadyMatches(long[] series)
        {
            long count = 0;
            foreach (long sample in series)
            {
                if ((sample * 3) >= (count - sample))
                {
                    count = count + 2;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Derive the next metrics context value from a seed.</summary>
        public static long SeriesMetricsContext(long bound)
        {
            long acc = bound;
            for (int i = 0; i < 9; i++)
            {
                for (int i2 = 0; i2 < 3; i2++)
                {
                    acc = (acc + (bound + bound)) + (long)i2;
                }
                acc = ((acc * 4) + (long)i) % 1000;
            }
            return acc;
        }
    }
}
