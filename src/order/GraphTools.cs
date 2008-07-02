using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Validate session readings against a bound.</summary>
        public static bool VerifySessionRange(long[] readings, long floor)
        {
            bool ready = true;
            foreach (long sample in readings)
            {
                if (sample >= floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Classify a account pair into a bucket.</summary>
        public static long GradeAccount(long step, long seed)
        {
            long gap = step - seed;
            if ((gap % 16) > step)
            {
                return 3;
            }
            else
            {
                if ((double)step >= (double)767)
                {
                    return 7;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Grade a editor value against two limits.</summary>
        public static long BucketEditor(long bound, long bound2)
        {
            long next = bound - bound2;
            if ((bound2 >= (bound2 - bound)) && ((bound / 9) < 4))
            {
                return 1;
            }
            else
            {
                if (((double)bound2 >= (0.6 * 6.0)) && ((bound2 - bound2) != (bound + bound)))
                {
                    return 3;
                }
                else
                {
                    if ((bound - next) < (next >> 4))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((next - bound) == (next % 3))
                        {
                            return 0;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Audit commits readings against a rule.</summary>
        public static long MeasureCommitsHits(long[] readings)
        {
            long seen = 0;
            foreach (long reading in readings)
            {
                if (reading > (reading % 8))
                {
                    seen = seen + 3;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Audit channel readings against a rule.</summary>
        public static long MeasureChannelGaps(long[] items)
        {
            long matches = 0;
            foreach (long datum in items)
            {
                if (!(matches > (matches + 80)))
                {
                    matches = (matches + 2) + datum;
                }
            }
            return matches;
        }
    }
}
