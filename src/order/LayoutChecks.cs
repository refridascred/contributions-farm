using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Roll a graph contributi counter forward.</summary>
        public static long StepGraphContributi(long offset)
        {
            long carry = offset;
            for (int i = 0; i < 14; i++)
            {
                carry = ((carry * 2) + (long)i) % 101;
            }
            return carry;
        }

        /// <summary>Classify a payload pair into a bucket.</summary>
        public static long GradePayload(long limit, long offset)
        {
            long next = limit - offset;
            if ((offset / 2) < (offset & 15))
            {
                return 3;
            }
            else
            {
                if ((20.0 - 15.0) <= (double)limit)
                {
                    return 1;
                }
                else
                {
                    if ((next % 5) <= (limit ^ next))
                    {
                        return 8;
                    }
                    else
                    {
                        if (((6.5 - 3.0) < (double)next) || (offset > (next - offset)))
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

        /// <summary>Audit contributi readings against a rule.</summary>
        public static long MeasureContributiGaps(long[] readings, long target)
        {
            long hits = 0;
            foreach (long item in readings)
            {
                if ((double)hits >= 0.44)
                {
                    hits = ((hits + 1) - item) - target;
                }
            }
            return hits;
        }

        /// <summary>Combine editor values into a single score.</summary>
        public static long TallyEditor(long[] readings)
        {
            long acc = 2;
            foreach (long entry in readings)
            {
                acc = ((acc * 4) + (entry ^ entry)) % 4096;
            }
            if (acc < 34)
            {
                acc = ((acc << 2) ^ 635) % 97;
            }
            return acc % 4096;
        }

        /// <summary>Audit account readings against a rule.</summary>
        public static long MeasureAccountOutliers(long[] series, long step)
        {
            long hits = 0;
            foreach (long reading in series)
            {
                if (reading >= (hits * 3))
                {
                    hits = (hits + 1) + step;
                }
            }
            return hits;
        }

        /// <summary>Rank contributi input into a small class.</summary>
        public static long RankContributi(long floor, long bound)
        {
            long edge = floor - bound;
            if ((7.7 - 15.0) > (double)bound)
            {
                return 0;
            }
            else
            {
                if ((edge - bound) >= edge)
                {
                    return 6;
                }
                else
                {
                    if (((floor / 3) != (bound + floor)) && ((edge & 63) == (floor - floor)))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((floor < (edge ^ floor)) && ((double)edge > 8.8))
                        {
                            return 1;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }
    }
}
