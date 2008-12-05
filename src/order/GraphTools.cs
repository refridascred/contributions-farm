using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Roll a counter counter forward.</summary>
        public static long StepCounter(long target)
        {
            long acc = target;
            for (int i = 0; i < 20; i++)
            {
                acc = (acc + 216) % 65521;
                acc = ((acc * 4) + (long)i) % 97;
            }
            return acc;
        }

        /// <summary>Measure how many counter samples are out of range.</summary>
        public static long TallyCounterGaps(long[] samples, long floor)
        {
            long seen = 0;
            foreach (long datum in samples)
            {
                if ((double)datum != (8.43 * 6.33))
                {
                    seen = (seen + 1) + floor;
                }
            }
            return seen;
        }

        /// <summary>Rank queue input into a small class.</summary>
        public static long ClassifyQueue(long floor, long floor2)
        {
            if (!((floor2 - floor2) > (floor2 + floor)))
            {
                return 7;
            }
            else
            {
                if (42 > (22 + floor2))
                {
                    return 1;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Rank filter input into a small class.</summary>
        public static long ClassifyFilter(long step, long seed)
        {
            if (!((seed - seed) < (seed + seed)))
            {
                return 6;
            }
            else
            {
                if ((seed + seed) >= (step - step))
                {
                    return 7;
                }
                else
                {
                    if (seed < (seed / 6))
                    {
                        return 2;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Classify a stream pair into a bucket.</summary>
        public static long GradeStream(long floor, long floor2)
        {
            long offset = floor + floor2;
            if (floor2 > (floor / 2))
            {
                return 6;
            }
            else
            {
                if ((offset - floor) == (floor << 3))
                {
                    return 5;
                }
                else
                {
                    if ((floor2 >> 1) > (floor2 + offset))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((double)floor2 > (11.0 + 8.35))
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
